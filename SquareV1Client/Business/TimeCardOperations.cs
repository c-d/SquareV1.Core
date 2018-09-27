using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Net.Http;
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

        public Task<HttpOperationResponse<IList<Timecard>>> GetWithHttpMessagesAsync(ListOrderType? order = null,
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

            return GetWithHttpMessagesAsync<IList<Timecard>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Timecard>> GetWithHttpMessagesAsync(string timecardId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetWithHttpMessagesAsync<Timecard>(GetUri().Append(timecardId), customHeaders, cancellationToken);
        }

        public async Task<HttpOperationResponse> PostWithHttpMessagesAsync(Timecard value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (value == null) throw new ValidationException(ValidationRules.CannotBeNull, "value");

            // Create HTTP transport objects
            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("POST"),
                RequestUri = GetUri(),
            };

            SetHeaders(httpRequest, customHeaders);
            var requestcontent = SerializeRequest<Timecard>(value, httpRequest);
            await SetCredentialsAsync(httpRequest, cancellationToken);

            // Send Request
            HttpResponseMessage httpResponse = null;
            cancellationToken.ThrowIfCancellationRequested();
            httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            var _statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;

            if ((int)_statusCode != 204)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                _responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                ex.Request = new HttpRequestMessageWrapper(httpRequest, requestcontent);
                ex.Response = new HttpResponseMessageWrapper(httpResponse, _responseContent);
                httpRequest.Dispose();
                if (httpResponse != null)
                {
                    httpResponse.Dispose();
                }
                throw ex;
            }

            return new HttpOperationResponse
            {
                Request = httpRequest,
                Response = httpResponse,
            };
        }

        public async Task<HttpOperationResponse> PutWithHttpMessagesAsync(string roleId, Timecard value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (value == null) throw new ValidationException(ValidationRules.CannotBeNull, "value");

            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("PUT"),
                RequestUri = GetUri().Append(roleId),
            };

            SetHeaders(httpRequest, customHeaders);
            var requestcontent = SerializeRequest(value, httpRequest);
            await SetCredentialsAsync(httpRequest, cancellationToken);

            cancellationToken.ThrowIfCancellationRequested();

            var httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            var statusCode = httpResponse.StatusCode;

            cancellationToken.ThrowIfCancellationRequested();

            string _responseContent = null;

            if ((int)statusCode != 204)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", statusCode));
                _responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                ex.Request = new HttpRequestMessageWrapper(httpRequest, requestcontent);
                ex.Response = new HttpResponseMessageWrapper(httpResponse, _responseContent);

                httpRequest.Dispose();

                if (httpResponse != null) httpResponse.Dispose();

                throw ex;
            }

            return new HttpOperationResponse
            {
                Request = httpRequest,
                Response = httpResponse,
            };
        }

        public Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string roleId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri().Append(roleId);

            return DeleteWithHttpMessagesAsync<IList<Timecard>>(uri, customHeaders, cancellationToken);
        }

        protected override Uri GetUri(params string[] values)
        {
            return BaseUri.Append("me", "timecards");
        }
    }
}