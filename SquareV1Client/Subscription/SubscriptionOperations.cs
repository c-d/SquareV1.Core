using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Subscription
{
    public class SubscriptionOperations : Operations, ISubscriptionOperations
    {
        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public SubscriptionOperations(Client client) : base(client) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns>https://connect.squareup.com/v1/{{location_id}}/webhooks</returns>
        protected override Uri GetUri(params string[] values)
        {
            switch (values.Length)
            {
                case 1: return BaseUri.Append("webhooks");
                default: throw new ArgumentException();
            }
        }

        public Task<HttpOperationResponse<IList<Subscription>>> GetWithHttpMessagesAsync(string clientId,
            string merchantId = null,
            short? limit = null,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(clientId).AppendParameters("merchant_id", merchantId, "limit", limit.HasValue ? limit.Value.ToString() : null);

            return GetWithHttpMessagesAsync<IList<Subscription>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Subscription>> GetWithHttpMessagesAsync(string clientId,
            string subscriptionId,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetWithHttpMessagesAsync<Subscription>(GetUri(clientId, subscriptionId), customHeaders, cancellationToken);
        }
    }
}