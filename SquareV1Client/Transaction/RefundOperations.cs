using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Transaction
{
    public class RefundOperations : Operations, IRefundOperations
    {
        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public RefundOperations(Client client) : base(client) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns>https://connect.squareup.com/v1/{{location_id}}/payments</returns>
        protected override Uri GetUri(params string[] values)
        {
            switch (values.Length)
            {
                case 1: return BaseUri.Append(values[0], "refunds");
                default: throw new ArgumentException();
            }
        }

        public Task<HttpOperationResponse<IList<Refund>>> GetWithHttpMessagesAsync(string locationId,
            DateTime? beginTime,
            DateTime? endTime,
            ListOrderType? listOrder,
            short? limit,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId)
                .AppendDateRange("begin_time", beginTime, "end_time", endTime)
                .AppendOrderOrLimit(limit, listOrder);

            return GetWithHttpMessagesAsync<IList<Refund>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Refund>> GetWithHttpMessagesAsync(string locationId,
            string paymentId,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetWithHttpMessagesAsync(locationId, paymentId, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Refund>> PostWithHttpMessagesAsync(string locationId, Refund value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId);

            return PostWithHttpMessagesAsync(uri, value, customHeaders, cancellationToken);
        }
    }
}