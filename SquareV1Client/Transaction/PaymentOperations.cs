using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Transaction
{
    public class PaymentOperations : Operations, IPaymentOperations
    {
        const string _UriFormat = "{0}/payments";

        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public PaymentOperations(Client client) : base(client) { }

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

        public Task<HttpOperationResponse<IList<Payment>>> GetWithHttpMessagesAsync(string locationId,
            DateTime? beginTime,
            DateTime? endTime,
            RangeOrderType? dateRangeOrder,
            short? take,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId)
                .AppendDateRange(beginTime, endTime)
                .AppendOrderOrLimit(take, dateRangeOrder);

            return GetWithHttpMessagesAsync(uri, customHeaders, cancellationToken);
        }

        Task<HttpOperationResponse<IList<Payment>>> GetWithHttpMessagesAsync(Uri uri = null,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            // Create HTTP transport objects
            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("GET"),
                RequestUri = uri ?? BaseUri,
            };

            return GetWithHttpMessagesAsync<IList<Payment>>(uri ?? BaseUri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Payment>> GetWithHttpMessagesAsync(string locationId,
            string paymentId,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetWithHttpMessagesAsync(locationId: locationId, paymentId: paymentId, customHeaders: customHeaders, cancellationToken: cancellationToken);
        }

        public Task<HttpOperationResponse> PostWithHttpMessagesAsync(string locationId, Payment value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotSupportedException();
        }

        public Task<HttpOperationResponse> PutWithHttpMessagesAsync(string locationId, Payment value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotSupportedException();
        }

        public Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string locationId, string paymentId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotSupportedException();
        }
    }
}