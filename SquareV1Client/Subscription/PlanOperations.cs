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
                case 1: return BaseUri.Append("oauth2", "clients", values[0], "plans", values.Length > 1 ? values[1] : null);
                default: throw new ArgumentException();
            }
        }

        public Task<HttpOperationResponse<IList<SubscriptionPlan>>> GetWithHttpMessagesAsync(string clientId,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(clientId);

            return GetWithHttpMessagesAsync<IList<SubscriptionPlan>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<SubscriptionPlan>> GetWithHttpMessagesAsync(string clientId,
            string planId,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetWithHttpMessagesAsync<SubscriptionPlan>(GetUri(clientId,planId), customHeaders, cancellationToken);
        }
    }
}