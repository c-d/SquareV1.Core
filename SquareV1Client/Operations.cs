using Microsoft.Rest;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1
{
    /// <summary>
    /// Operations implementing HTTP Verbs.
    /// </summary>
    public abstract class Operations : IOperations
    {
        /// <summary>
        /// Gets a reference to the SquareAppriseTransferWebJobClient
        /// </summary>
        public Client Client { get; private set; }

        /// <summary>
        /// Base URI to use for all operations.
        /// </summary>
        public Uri BaseUri { get; set; }

        /// <summary>
        /// A method to create a complete URI needed for an operation.
        /// </summary>
        /// <param name="values">Any number of segments to append to the base URI.</param>
        /// <returns>The complete URI.</returns>
        /// <remarks>This will be used by child classes to add specific route and parameter values.</remarks>
        protected abstract Uri GetUri(params string[] values);

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="client">A reference to the SquareAppriseTransferWebJobClient</param>
        public Operations(Client client)
        {
            Client = client ?? throw new ArgumentNullException("client");
            BaseUri = client.BaseUri;
        }

        /// <summary>
        /// Set any custom headers to the HTTP request.
        /// </summary>
        /// <param name="httpRequest">Request on which to set headers.</param>
        /// <param name="customHeaders">Header collection to set.</param>
        protected static void SetHeaders(HttpRequestMessage httpRequest, Dictionary<string, List<string>> customHeaders)
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

        /// <summary>
        /// Set request credentials.
        /// </summary>
        /// <param name="httpRequest">Request on which to set credentials.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Task.</returns>
        protected async Task SetCredentialsAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken)
        {
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Deserialize HTTP response.
        /// </summary>
        /// <typeparam name="T">Type which to deserialize response body as.</typeparam>
        /// <param name="httpRequest">HTTP request.</param>
        /// <param name="httpResponse">HTTP response.</param>
        /// <returns>Asynchronous typed operation response.</returns>
        protected async Task<HttpOperationResponse<T>> DeserializeResponseAsync<T>(HttpRequestMessage httpRequest, HttpResponseMessage httpResponse)
        {
            // Create Result
            var result = new HttpOperationResponse<T>
            {
                Request = httpRequest,
                Response = httpResponse
            };

            if (httpResponse.IsSuccessStatusCode)
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

        /// <summary>
        /// Serialize request.
        /// </summary>
        /// <typeparam name="T">Type which to serialize.</typeparam>
        /// <param name="value">Value which to serialize.</param>
        /// <param name="httpRequest">Request in which to place the serialized value.</param>
        /// <returns></returns>
        protected void SerializeRequest<T>(T value, HttpRequestMessage httpRequest)
        {
            if (value != null)
            {
                var requestContent = SafeJsonConvert.SerializeObject(value, Client.SerializationSettings);
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            }
        }

        async static Task<HttpOperationException> HandleUnsuccessfulRequest(HttpRequestMessage request, HttpResponseMessage response)
        {
            var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", response.StatusCode));

            string requestContent = null;

            var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            ex.Request = new HttpRequestMessageWrapper(request, requestContent);
            ex.Response = new HttpResponseMessageWrapper(response, responseContent);
            request.Dispose();

            if (response != null) response.Dispose();

            return ex;
        }

        static HttpRequestMessage GetRequest(Uri uri, string verbName)
        {
            return new HttpRequestMessage
            {
                Method = new HttpMethod(verbName),
                RequestUri = uri,
            };
        }

        /// <summary>
        /// Run a GET request on the URI and return the request and resonse messages.
        /// </summary>
        /// <typeparam name="T">Type which to deserialize the response body to.</typeparam>
        /// <param name="uri">URI to run the request upon.</param>
        /// <param name="customHeaders">Any custom headers to use in the request.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public async Task<HttpOperationResponse<T>> GetWithHttpMessagesAsync<T>(Uri uri,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var httpRequest = GetRequest(uri, "GET");

            SetHeaders(httpRequest, customHeaders);
            await SetCredentialsAsync(httpRequest, cancellationToken);

            cancellationToken.ThrowIfCancellationRequested();

            var httpResponse = await Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);

            cancellationToken.ThrowIfCancellationRequested();

            if (!httpResponse.IsSuccessStatusCode)
                throw await HandleUnsuccessfulRequest(httpRequest, httpResponse);
            else
                return await DeserializeResponseAsync<T>(httpRequest, httpResponse);
        }

        protected Task<HttpOperationResponse<T>> PostWithHttpMessagesAsync<T>(Uri uri, T value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostWithHttpMessagesAsync<T, T>(uri, value, customHeaders, cancellationToken);
        }

        protected async Task<HttpOperationResponse<TResponse>> PostWithHttpMessagesAsync<TRequest, TResponse>(Uri uri, TRequest value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (value == null) throw new ValidationException(ValidationRules.CannotBeNull, "value");

            var httpRequest = GetRequest(uri, "POST");

            SetHeaders(httpRequest, customHeaders);
            SerializeRequest(value, httpRequest);
            await SetCredentialsAsync(httpRequest, cancellationToken);

            cancellationToken.ThrowIfCancellationRequested();

            var httpResponse = await Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);

            cancellationToken.ThrowIfCancellationRequested();

            if (!httpResponse.IsSuccessStatusCode)
                throw await HandleUnsuccessfulRequest(httpRequest, httpResponse);
            else
                return await DeserializeResponseAsync<TResponse>(httpRequest, httpResponse);
        }

        protected Task<HttpOperationResponse<T>> PutWithHttpMessagesAsync<T>(Uri uri, T value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PutWithHttpMessagesAsync<T, T>(uri, value, customHeaders, cancellationToken);
        }

        protected async Task<HttpOperationResponse<TResponse>> PutWithHttpMessagesAsync<TRequest, TResponse>(Uri uri, TRequest value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (value == null) throw new ValidationException(ValidationRules.CannotBeNull, "value");

            var httpRequest = GetRequest(uri, "PUT");

            SetHeaders(httpRequest, customHeaders);
            SerializeRequest(value, httpRequest);
            await SetCredentialsAsync(httpRequest, cancellationToken);

            cancellationToken.ThrowIfCancellationRequested();

            var httpResponse = await Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);

            cancellationToken.ThrowIfCancellationRequested();

            if (!httpResponse.IsSuccessStatusCode)
                throw await HandleUnsuccessfulRequest(httpRequest, httpResponse);
            else
                return await DeserializeResponseAsync<TResponse>( httpRequest, httpResponse);
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

            if (!httpResponse.IsSuccessStatusCode)
                throw await HandleUnsuccessfulRequest(httpRequest, httpResponse);
            else
                return new HttpOperationResponse
                {
                    Request = httpRequest,
                    Response = httpResponse
                };
        }
    }
}