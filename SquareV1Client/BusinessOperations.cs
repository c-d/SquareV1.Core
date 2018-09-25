using MeyerCorp.Square.V1.Models;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1
{
    public class BusinessOperations : Operations, IBusinessOperations
    {
        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public BusinessOperations(Client client) : base(client) { }

        public async Task<HttpOperationResponse<Merchant>> GetWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Create HTTP transport objects
            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("GET"),
                RequestUri = GetUri(),
            };

            SetHeaders(httpRequest, customHeaders);
            await SetCredentialsAsync(httpRequest, cancellationToken);

            cancellationToken.ThrowIfCancellationRequested();

            var httpResponse = await Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            var statusCode = httpResponse.StatusCode;

            cancellationToken.ThrowIfCancellationRequested();

            string responseContent = null;
            string requestContent = null;

            if ((int)statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", statusCode));

                responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                ex.Request = new HttpRequestMessageWrapper(httpRequest, requestContent);
                ex.Response = new HttpResponseMessageWrapper(httpResponse, responseContent);
                httpRequest.Dispose();

                if (httpResponse != null) httpResponse.Dispose();

                throw ex;
            }

            return await DeserializeResponseAsync<Merchant>(statusCode, httpRequest, httpResponse);
        }

        public async Task<HttpOperationResponse<Merchant>> GetWithHttpMessagesAsync(string locationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Create HTTP transport objects
            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("GET"),
                RequestUri = GetUri(locationId),
            };

            SetHeaders(httpRequest, customHeaders);
            await SetCredentialsAsync(httpRequest, cancellationToken);

            cancellationToken.ThrowIfCancellationRequested();

            var httpResponse = await Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            var statusCode = httpResponse.StatusCode;

            cancellationToken.ThrowIfCancellationRequested();

            string responseContent = null;
            string requestContent = null;

            if ((int)statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", statusCode));

                responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                ex.Request = new HttpRequestMessageWrapper(httpRequest, requestContent);
                ex.Response = new HttpResponseMessageWrapper(httpResponse, responseContent);
                httpRequest.Dispose();

                if (httpResponse != null) httpResponse.Dispose();

                throw ex;
            }

            return await DeserializeResponseAsync<Merchant>(statusCode, httpRequest, httpResponse);
        }

        public Task<HttpOperationResponse> PostWithHttpMessagesAsync(Merchant value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotSupportedException();
        }

        public Task<HttpOperationResponse> PutWithHttpMessagesAsync(string id, Merchant value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotSupportedException();
        }

        public Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns>https://connect.squareup.com/v1/{{location_id}}/business</returns>
        protected override Uri GetUri(params string[] values)
        {
            switch (values.Length)
            {
                case 0: return BaseUri.Append("me");
                case 1: return BaseUri.Append(values[0], "business");
                default: throw new ArgumentException();
            }
        }
    }
}