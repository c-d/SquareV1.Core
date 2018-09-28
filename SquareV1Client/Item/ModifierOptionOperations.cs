using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Item
{
    public class ModifierOptionOperations : Operations, IModifierOptionOperations
    {
        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public ModifierOptionOperations(Client client) : base(client) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns>https://connect.squareup.com/v1/modifier-lists/{modifier_list_id}/modifier-options</returns>
        protected override Uri GetUri(params string[] values)
        {
            switch (values.Length)
            {
                case 1: return BaseUri.Append(values[0], "modifier-lists", values[1], "modifier-options");
                default: throw new ArgumentException();
            }
        }
        public Task<HttpOperationResponse> PostWithHttpMessagesAsync(string locationId, string modifierListId, ModifierOption value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId, modifierListId);

            return PostWithHttpMessagesAsync(uri, value, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse> PutWithHttpMessagesAsync(string locationId, string modifierListId, string id, ModifierOption value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId, modifierListId).Append(id);

            return PutWithHttpMessagesAsync(uri, value,customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string locationId, string modifierListId, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId, modifierListId).Append(id);

            return DeleteWithHttpMessagesAsync<ModifierOption>(uri, customHeaders, cancellationToken);
        }
    }
}