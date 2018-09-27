using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Item
{
    public class CategoryOperations : Operations, ICategoryOperations
    {
        const string _UriFormat = "{0}/payments";

        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public CategoryOperations(Client client) : base(client) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns>https://connect.squareup.com/v1/{{location_id}}/payments</returns>
        protected override Uri GetUri(params string[] values)
        {
            switch (values.Length)
            {
                case 1: return BaseUri.Append(values[0], "categories");
                default: throw new ArgumentException();
            }
        }

        public Task<HttpOperationResponse<IList<Category>>> GetWithHttpMessagesAsync(string locationId,
            bool isContinous = false,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId);

            return GetWithHttpMessagesAsync<IList<Category>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Category>> GetWithHttpMessagesAsync(string locationId,
            string id,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetWithHttpMessagesAsync(locationId, id, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse> PostWithHttpMessagesAsync(string locationId, Category value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId);

            return PostWithHttpMessagesAsync<Category>(uri, value, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse> PutWithHttpMessagesAsync(string locationId, string id, Category value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId).Append(id);

            return PutWithHttpMessagesAsync<Category>(uri, value, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string locationId, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId).Append(id);

            return DeleteWithHttpMessagesAsync<Category>(uri, customHeaders, cancellationToken);
        }
    }
}