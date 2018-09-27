using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Business
{
    public class CashDrawerShiftOperations : Operations, ICashDrawerShiftOperations
    {
        /// <summary>
        /// Initializes a new instance of the CashDrawerShiftsOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public CashDrawerShiftOperations(Client client) : base(client) { }

        public Task<HttpOperationResponse<IList<CashDrawerShift>>> GetWithHttpMessagesAsync(string locationId,
            ListOrderType? order = null,
            DateTime? beginTime = null,
            DateTime? endTime = null,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId)
                .AppendOrderOrLimit(null, order)
                .AppendDateRange("begin_time", beginTime, "end_time", endTime);

            return GetWithHttpMessagesAsync<IList<CashDrawerShift>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<CashDrawerShift>> GetWithHttpMessagesAsync(string locationId, string timecardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetWithHttpMessagesAsync<CashDrawerShift>(GetUri().Append(timecardId), customHeaders, cancellationToken);
        }

        public HttpOperationResponse PostWithHttpMessages(string locationId, CashDrawerShift value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotSupportedException();
        }

        public HttpOperationResponse PutWithHttpMessages(string locationId, string id, CashDrawerShift value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotSupportedException();
        }

        public HttpOperationResponse DeleteWithHttpMessagesAsync(string locationId, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotSupportedException();
        }

        protected override Uri GetUri(params string[] values)
        {
            return BaseUri.Append("me", values[0], "cash-drawer-shifts");
        }
    }
}