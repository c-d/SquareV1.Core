using Microsoft.Rest;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1
{
    public abstract class Operations : IOperations
    {
        /// <summary>
        /// Gets a reference to the SquareAppriseTransferWebJobClient
        /// </summary>
        public Client Client { get; private set; }

        public Uri BaseUri { get; set; }

        protected abstract Uri GetUri(params string[] values);

        public Operations(Client client)
        {
            Client = client ?? throw new ArgumentNullException("client");
            BaseUri = client.BaseUri;
        }

        protected void SetHeaders(HttpRequestMessage httpRequest, Dictionary<string, List<string>> customHeaders)
        {
            if (customHeaders != null)
            {
                foreach (var _header in customHeaders)
                {
                    if (httpRequest.Headers.Contains(_header.Key))
                        httpRequest.Headers.Remove(_header.Key);

                    httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }
        }

        protected async Task SetCredentialsAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken)
        {
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            }
        }

        protected async Task<HttpOperationResponse<T>> DeserializeResponseAsync<T>(HttpStatusCode statusCode, HttpRequestMessage httpRequest, HttpResponseMessage httpResponse)
        {
            // Create Result
            var result = new HttpOperationResponse<T>
            {
                Request = httpRequest,
                Response = httpResponse
            };

            if ((int)statusCode == 200)
            {
                var responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    result.Body = SafeJsonConvert.DeserializeObject<T>(responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    httpRequest.Dispose();

                    if (httpResponse != null) httpResponse.Dispose();

                    throw new SerializationException("Unable to deserialize the response.", responseContent, ex);
                }
            }

            return result;
        }

        protected string SerializeRequest<T>(T value, HttpRequestMessage httpRequest)
        {
            string requestContent = null;

            if (value != null)
            {
                requestContent = SafeJsonConvert.SerializeObject(value, this.Client.SerializationSettings);
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            }

            return requestContent;
        }

        public async Task<HttpOperationResponse<T>> GetWithHttpMessagesAsync<T>(Uri uri,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("GET"),
                RequestUri = uri,
            };

            SetHeaders(httpRequest, customHeaders);
            await SetCredentialsAsync(httpRequest, cancellationToken);

            cancellationToken.ThrowIfCancellationRequested();

            var httpResponse = await Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            var statusCode = httpResponse.StatusCode;

            cancellationToken.ThrowIfCancellationRequested();

            if ((int)statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", statusCode));

                string requestContent = null;

                var responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                ex.Request = new HttpRequestMessageWrapper(httpRequest, requestContent);
                ex.Response = new HttpResponseMessageWrapper(httpResponse, responseContent);
                httpRequest.Dispose();

                if (httpResponse != null) httpResponse.Dispose();

                throw ex;
            }

            return await DeserializeResponseAsync<TResponse>(statusCode, httpRequest, httpResponse);
        }

        protected async Task<HttpOperationResponse> DeleteWithHttpMessagesAsync<T>(Uri uri, Dictionary<string, List<string>> customHeaders, CancellationToken cancellationToken)
        {
            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("DELETE"),
                RequestUri = uri,
            };

            SetHeaders(httpRequest, customHeaders);
            await SetCredentialsAsync(httpRequest, cancellationToken);

            cancellationToken.ThrowIfCancellationRequested();

            var httpResponse = await Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            var statusCode = httpResponse.StatusCode;

            cancellationToken.ThrowIfCancellationRequested();

            if ((int)statusCode != 204)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", statusCode));
                var responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                ex.Request = new HttpRequestMessageWrapper(httpRequest, responseContent);
                ex.Response = new HttpResponseMessageWrapper(httpResponse, responseContent);
                httpRequest.Dispose();
                if (httpResponse != null) httpResponse.Dispose();

                throw ex;
            }

            return new HttpOperationResponse
            {
                Request = httpRequest,
                Response = httpResponse
            };
        }

        protected Task<HttpOperationResponse<T>> PostWithHttpMessagesAsync<T>(Uri uri, T value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostWithHttpMessagesAsync<T, T>(uri, value, customHeaders, cancellationToken);
        }

        protected async Task<HttpOperationResponse<TResponse>> PostWithHttpMessagesAsync<TRequest, TResponse>(Uri uri, TRequest value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (value == null) throw new ValidationException(ValidationRules.CannotBeNull, "value");

            // Create HTTP transport objects
            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("POST"),
                RequestUri = uri,
            };

            SetHeaders(httpRequest, customHeaders);
            var requestcontent = SerializeRequest<TRequest>(value, httpRequest);
            await SetCredentialsAsync(httpRequest, cancellationToken);

            // Send Request
            HttpResponseMessage httpResponse = null;
            cancellationToken.ThrowIfCancellationRequested();
            httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            var statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;

            if ((int)statusCode != 204)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", statusCode));
                _responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                ex.Request = new HttpRequestMessageWrapper(httpRequest, requestcontent);
                ex.Response = new HttpResponseMessageWrapper(httpResponse, _responseContent);
                httpRequest.Dispose();
                if (httpResponse != null)
                {
                    httpResponse.Dispose();
                }
                throw ex;
            }

            return await DeserializeResponseAsync<TResponse>(statusCode, httpRequest, httpResponse);
        }

        protected async Task<HttpOperationResponse> PutWithHttpMessagesAsync<T>(Uri uri, T value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (value == null) throw new ValidationException(ValidationRules.CannotBeNull, "value");

            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("PUT"),
                RequestUri = uri,
            };

            SetHeaders(httpRequest, customHeaders);
            var requestcontent = SerializeRequest(value, httpRequest);
            await SetCredentialsAsync(httpRequest, cancellationToken);

            cancellationToken.ThrowIfCancellationRequested();

            var httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            var statusCode = httpResponse.StatusCode;

            cancellationToken.ThrowIfCancellationRequested();

            string _responseContent = null;

            if ((int)statusCode != 204)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", statusCode));
                _responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                ex.Request = new HttpRequestMessageWrapper(httpRequest, requestcontent);
                ex.Response = new HttpResponseMessageWrapper(httpResponse, _responseContent);

                httpRequest.Dispose();

                if (httpResponse != null) httpResponse.Dispose();

                throw ex;
            }

            return new HttpOperationResponse
            {
                Request = httpRequest,
                Response = httpResponse,
            };
        }
    }
}