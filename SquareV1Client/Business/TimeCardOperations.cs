using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Business
{
    public class TimecardOperations : Operations, ITimecardOperations
    {
        /// <summary>
        /// Initializes a new instance of the TimecardsOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public TimecardOperations(Client client) : base(client) { }

        public Task<HttpOperationResponse<IEnumerable<Timecard>>> GetWithHttpMessagesAsync(ListOrderType? order = null,
            string employeeId = null,
            DateTime? beginClockIn = null,
            DateTime? endClockIn = null,
            DateTime? beginClockOut = null,
            DateTime? endClockOut = null,
            DateTime? beginUpdated = null,
            DateTime? endUpdated = null,
            bool? isDeleted = null,
            short? limit = null,
            bool isContinous = false,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri()
                .AppendOrderOrLimit(limit, order)
                .AppendParameters("deleted", isDeleted.HasValue ? isDeleted.Value.ToString().ToLowerInvariant() : null)
                .AppendDateRange("begin_clockin_time", beginClockIn, "end_clockin_time", beginClockIn)
                .AppendDateRange("begin_clockout_time", beginClockOut, "end_clockout_time", endClockOut)
                .AppendDateRange("begin_updated_at", beginUpdated, "end_updated_at", endUpdated);

            return GetWithHttpMessagesAsync<IEnumerable<Timecard>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Timecard>> GetWithHttpMessagesAsync(string timecardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetWithHttpMessagesAsync<Timecard>(GetUri().Append(timecardId), customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Timecard>> PostWithHttpMessagesAsync(Timecard value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri();

            return PostWithHttpMessagesAsync(uri, value, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Timecard>> PutWithHttpMessagesAsync(string roleId, Timecard value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri().Append(roleId);

            return PutWithHttpMessagesAsync(uri, value, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string roleId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri().Append(roleId);

            return DeleteWithHttpMessagesAsync<IEnumerable<Timecard>>(uri, customHeaders, cancellationToken);
        }

        protected override Uri GetUri(params string[] values)
        {
            return BaseUri.Append("me", "timecards");
        }
    }
}