using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Business
{
    public class LocationOperations : Operations, ILocationOperations
    {
        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public LocationOperations(Client client) : base(client) { }

        public Task<HttpOperationResponse<IEnumerable<Merchant>>> GetWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri();

            return GetWithHttpMessagesAsync<IEnumerable<Merchant>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Merchant>> GetWithHttpMessagesAsync(string locationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri().Append(locationId);

            return GetWithHttpMessagesAsync<Merchant>(uri, customHeaders, cancellationToken);
        }

        protected override Uri GetUri(params string[] values)
        {
            return BaseUri.Append("me", "locations");
        }
    }
}