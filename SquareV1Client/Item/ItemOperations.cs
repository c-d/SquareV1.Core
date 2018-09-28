using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Item
{
    public class ItemOperations : Operations, IItemOperations
    {
        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public ItemOperations(Client client) : base(client) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns>https://connect.squareup.com/v1/{{location_id}}/payments</returns>
        protected override Uri GetUri(params string[] values)
        {
            switch (values.Length)
            {
                case 1: return BaseUri.Append(values[0], "items");
                default: throw new ArgumentException();
            }
        }

        public Task<HttpOperationResponse<IList<Item>>> GetWithHttpMessagesAsync(string locationId,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId);

            return GetWithHttpMessagesAsync<IList<Item>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Item>> GetWithHttpMessagesAsync(string locationId,
            string id,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId).Append(id);

            return GetWithHttpMessagesAsync<Item>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse> PostWithHttpMessagesAsync(string locationId, Item value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId);

            return PostWithHttpMessagesAsync(uri, value, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse> PutWithHttpMessagesAsync(string locationId, string id, Item value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId).Append(id);

            return PutWithHttpMessagesAsync(uri, value, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string locationId, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId).Append(id);

            return DeleteWithHttpMessagesAsync<Item>(uri, customHeaders, cancellationToken);
        }
    }
}