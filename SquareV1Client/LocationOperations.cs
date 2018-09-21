using MeyerCorp.Square.V1.Models;
using Microsoft.Rest;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1
{
    public class LocationOperations : IOperations<Merchant>
    {
        Uri BaseUri { get { return new Uri($"{Client.BaseUri.AbsoluteUri.ToString()}me/locations"); } }

        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public LocationOperations(Client client)
        {
            Client = client ?? throw new ArgumentNullException("client");
        }

        /// <summary>
        /// Gets a reference to the SquareAppriseTransferWebJobClient
        /// </summary>
        public Client Client { get; private set; }

        internal LocationOperations(Client client, Uri baseUri, string locationId)
        {
            Client = client;
        }

        public Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(int id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public async Task<HttpOperationResponse<IList<Merchant>>> GetWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken), Uri uri = null)
        {
            // Create HTTP transport objects
            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("GET"),
                RequestUri = uri ?? BaseUri,
            };

            SetHeaders(httpRequest, customHeaders);

            // Serialize Request
            string requestContent = null;

            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            }

            cancellationToken.ThrowIfCancellationRequested();

            var httpResponse = await Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);

            var statusCode = httpResponse.StatusCode;

            cancellationToken.ThrowIfCancellationRequested();

            string _responseContent = null;

            if ((int)statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", statusCode));

                _responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                ex.Request = new HttpRequestMessageWrapper(httpRequest, requestContent);
                ex.Response = new HttpResponseMessageWrapper(httpResponse, _responseContent);
                httpRequest.Dispose();

                if (httpResponse != null)
                    httpResponse.Dispose();

                throw ex;
            }
            // Create Result
            var result = new HttpOperationResponse<IList<Merchant>>
            {
                Request = httpRequest,
                Response = httpResponse
            };

            // Deserialize Response
            if ((int)statusCode == 200)
            {
                _responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    result.Body = SafeJsonConvert.DeserializeObject<IList<Merchant>>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    httpRequest.Dispose();

                    if (httpResponse != null)
                        httpResponse.Dispose();

                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }

            return result;
        }

        void SetHeaders(HttpRequestMessage httpRequest, Dictionary<string, List<string>> customHeaders)
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

        public Task<HttpOperationResponse> PostWithHttpMessagesAsync(Merchant value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<HttpOperationResponse> PutWithHttpMessagesAsync(int id, Merchant value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}