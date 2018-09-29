using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Item
{
    public class ModifierListOperations : Operations, IModifierListOperations
    {
        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public ModifierListOperations(Client client) : base(client) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns>https://connect.squareup.com/v1/{{location_id}}/modifier-lists</returns>
        protected override Uri GetUri(params string[] values)
        {
            switch (values.Length)
            {
                case 1: return BaseUri.Append(values[0], "modifier-lists");
                default: throw new ArgumentException();
            }
        }

        public Task<HttpOperationResponse<IList<ModifierList>>> GetWithHttpMessagesAsync(string locationId,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId);

            return GetWithHttpMessagesAsync<IList<ModifierList>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<ModifierList>> GetWithHttpMessagesAsync(string locationId,
            string id,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId).Append(id);

            return GetWithHttpMessagesAsync<ModifierList>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<ModifierList>> PostWithHttpMessagesAsync(string locationId, ModifierList value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId);

            return PostWithHttpMessagesAsync(uri, value, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<ModifierList>> PutWithHttpMessagesAsync(string locationId, string id, ModifierList value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId).Append(id);

            return PutWithHttpMessagesAsync(uri, value, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string locationId, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId).Append(id);

            return DeleteWithHttpMessagesAsync<ModifierList>(uri, customHeaders, cancellationToken);
        }
    }
}