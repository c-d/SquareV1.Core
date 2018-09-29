using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Subscription
{
    public class PlanOperations : Operations, IWebhookOperations
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

        public Task<HttpOperationResponse<IList<WebhookEventType>>> GetWithHttpMessagesAsync(string locationId,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId);

            return GetWithHttpMessagesAsync<IList<WebhookEventType>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<IList<WebhookEventType>>> PutWithHttpMessagesAsync(string locationId,
            IEnumerable<WebhookEventType> value,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId);

            return PutWithHttpMessagesAsync<IEnumerable<WebhookEventType>, IList<WebhookEventType>>(uri, value, customHeaders, cancellationToken);
        }
    }
}