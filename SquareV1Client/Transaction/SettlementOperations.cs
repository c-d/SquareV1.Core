using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Transaction
{
    public class SettlementOperations : Operations, ISettlementOperations
    {
        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public SettlementOperations(Client client) : base(client) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns>https://connect.squareup.com/v1/{{location_id}}/payments</returns>
        protected override Uri GetUri(params string[] values)
        {
            switch (values.Length)
            {
                case 1: return BaseUri.Append(values[0], "payments");
                default: throw new ArgumentException();
            }
        }

        public Task<HttpOperationResponse<IList<Settlement>>> GetWithHttpMessagesAsync(string locationId,
            DateTime? beginTime,
            DateTime? endTime,
            ListOrderType? listOrder,
            short? limit,
            SettlementStatus? status = null,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId)
                .AppendDateRange("begin_time", beginTime, "end_time", endTime)
                .AppendOrderOrLimit(limit, listOrder);

            return GetWithHttpMessagesAsync<IList<Settlement>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Settlement>> GetWithHttpMessagesAsync(string locationId,
            string id,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetWithHttpMessagesAsync(locationId, id, customHeaders, cancellationToken);
        }
    }
}