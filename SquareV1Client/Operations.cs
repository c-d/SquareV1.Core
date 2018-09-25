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
    public abstract class Operations
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
    }
}