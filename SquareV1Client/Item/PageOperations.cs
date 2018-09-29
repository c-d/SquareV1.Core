using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Item
{
    public class PageOperations : Operations, IPageOperations
    {
        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public PageOperations(Client client) : base(client) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns>https://connect.squareup.com/v1/{{location_id}}/payments</returns>
        protected override Uri GetUri(params string[] values)
        {
            switch (values.Length)
            {
                case 1: return BaseUri.Append(values[0], "pages");
                default: throw new ArgumentException();
            }
        }

        public Task<HttpOperationResponse<IList<Page>>> GetWithHttpMessagesAsync(string locationId,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId);

            return GetWithHttpMessagesAsync<IList<Page>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Page>> PostWithHttpMessagesAsync(string locationId, Page value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId);

            return PostWithHttpMessagesAsync(uri, value, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Page>> PutWithHttpMessagesAsync(string locationId, string id, Page value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId).Append(id);

            return PutWithHttpMessagesAsync(uri, value, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string locationId, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId).Append(id);

            return DeleteWithHttpMessagesAsync<Page>(uri, customHeaders, cancellationToken);
        }
    }
}