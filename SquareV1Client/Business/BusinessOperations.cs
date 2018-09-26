using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Business
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

        public Task<HttpOperationResponse<Merchant>> GetWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetWithHttpMessagesAsync<Merchant>(GetUri(), customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Merchant>> GetWithHttpMessagesAsync(string locationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetWithHttpMessagesAsync<Merchant>(GetUri(locationId), customHeaders, cancellationToken);
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