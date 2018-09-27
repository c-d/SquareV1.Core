using Microsoft.Rest;
using System;
using System.Collections.Generic;
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

        public Task<HttpOperationResponse<IList<Employee>>> GetWithHttpMessagesAsync(DateTime? created = null,
            DateTime? updated = null,
            EmployeeStatusType? status = null,
            string externalId = null,
            ListOrderType? listOrder = null,
            short? limit = null,
            bool isContinous = false,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri()
                    .AppendParameters("external_id", externalId, "status", status.HasValue ? status.Value.EnumToString() : null)
                    .AppendDateRange("created_at", created, "updated_at", updated);

            return GetWithHttpMessagesAsync<IList<Employee>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Employee>> GetWithHttpMessagesAsync(string employeeId, Dictionary<string, List<string>> customHeaders, CancellationToken cancellationToken)
        {
            var uri = GetUri().Append(employeeId);

            return GetWithHttpMessagesAsync<Employee>(uri, customHeaders, cancellationToken);

        }

        public Task<HttpOperationResponse> PostWithHttpMessagesAsync(Employee value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri();

            return PostWithHttpMessagesAsync<Employee>(uri, value, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse> PutWithHttpMessagesAsync(string employeeId, Employee value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri().Append(employeeId);

            return PutWithHttpMessagesAsync<Employee>(uri, value, customHeaders, cancellationToken);
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