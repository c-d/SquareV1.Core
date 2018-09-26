using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Business
{
    public class EmployeeOperations : Operations, IEmployeeOperations
    {
        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public EmployeeOperations(Client client) : base(client) { }

        public async Task<HttpOperationResponse<IList<Employee>>> GetWithHttpMessagesAsync(DateTime? created = null,
            DateTime? updated = null,
            EmployeeStatusType? status = null,
            string externalId = null,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("GET"),
                RequestUri = GetUri()
                    .AppendParameters("external_id", externalId, "status", status.HasValue ? status.Value.EnumToString() : null)
                    .AppendUpdatedCreatedDateFilter(created, updated),
            };

            SetHeaders(httpRequest, customHeaders);
            await SetCredentialsAsync(httpRequest, cancellationToken);

            cancellationToken.ThrowIfCancellationRequested();

            var httpResponse = await Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            var statusCode = httpResponse.StatusCode;

            cancellationToken.ThrowIfCancellationRequested();

            string responseContent = null;
            string requestContent = null;

            if ((int)statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", statusCode));

                responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                ex.Request = new HttpRequestMessageWrapper(httpRequest, requestContent);
                ex.Response = new HttpResponseMessageWrapper(httpResponse, responseContent);
                httpRequest.Dispose();

                if (httpResponse != null) httpResponse.Dispose();

                throw ex;
            }

            return await DeserializeResponseAsync<IList<Employee>>(statusCode, httpRequest, httpResponse);
        }

        public async Task<HttpOperationResponse<Employee>> GetWithHttpMessagesAsync(string employeeId, Dictionary<string, List<string>> customHeaders, CancellationToken cancellationToken)
        {
            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("GET"),
                RequestUri = GetUri().Append(employeeId),
            };

            SetHeaders(httpRequest, customHeaders);
            await SetCredentialsAsync(httpRequest, cancellationToken);

            cancellationToken.ThrowIfCancellationRequested();

            var httpResponse = await Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            var statusCode = httpResponse.StatusCode;

            cancellationToken.ThrowIfCancellationRequested();

            string responseContent = null;
            string requestContent = null;

            if ((int)statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", statusCode));

                responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                ex.Request = new HttpRequestMessageWrapper(httpRequest, requestContent);
                ex.Response = new HttpResponseMessageWrapper(httpResponse, responseContent);
                httpRequest.Dispose();

                if (httpResponse != null) httpResponse.Dispose();

                throw ex;
            }

            return await DeserializeResponseAsync<Employee>(statusCode, httpRequest, httpResponse);
        }

        public async Task<HttpOperationResponse> PostWithHttpMessagesAsync(Employee value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (value == null) throw new ValidationException(ValidationRules.CannotBeNull, "value");

            // Create HTTP transport objects
            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("POST"),
                RequestUri = GetUri(),
            };

            SetHeaders(httpRequest, customHeaders);
            var requestcontent = SerializeRequest<Employee>(value, httpRequest);
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

        public async Task<HttpOperationResponse> PutWithHttpMessagesAsync(string employeeId, Employee value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (value == null) throw new ValidationException(ValidationRules.CannotBeNull, "value");

            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("PUT"),
                RequestUri = GetUri().Append(employeeId),
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

        public Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string employeeId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotSupportedException();
        }

        protected override Uri GetUri(params string[] values)
        {
            return BaseUri.Append("me", "employees");
        }
    }
}