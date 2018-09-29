using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Subscription
{
    public class PlanOperations : Operations, IPlanOperations
    {
        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public PlanOperations(Client client) : base(client) { }

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

        public Task<HttpOperationResponse<IList<SubscriptionPlan>>> GetWithHttpMessagesAsync(string locationId,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId);

            return GetWithHttpMessagesAsync<IList<SubscriptionPlan>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<IList<SubscriptionPlan>>> PutWithHttpMessagesAsync(string locationId,
            IEnumerable<SubscriptionPlan> value,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId);

            return PutWithHttpMessagesAsync<IEnumerable<SubscriptionPlan>, IList<SubscriptionPlan>>(uri, value, customHeaders, cancellationToken);
        }
    }
}