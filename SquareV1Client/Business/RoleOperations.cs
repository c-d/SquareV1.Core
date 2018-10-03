using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Business
{
    public class RoleOperations : Operations, IRoleOperations
    {
        /// <summary>
        /// Initializes a new instance of the RolesOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public RoleOperations(Client client) : base(client) { }

        public Task<HttpOperationResponse<IEnumerable<Role>>> GetWithHttpMessagesAsync(ListOrderType? listOrder = null,
            short? limit = null,
            bool isContinous = false,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri().AppendOrderOrLimit(limit, listOrder);

            return GetWithHttpMessagesAsync<IEnumerable<Role>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Role>> GetWithHttpMessagesAsync(string roleId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetWithHttpMessagesAsync<Role>(GetUri().Append(roleId), customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Role>> PostWithHttpMessagesAsync(Role value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri();

            return PostWithHttpMessagesAsync(uri, value, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Role>> PutWithHttpMessagesAsync(string roleId, Role value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(roleId);

            return PutWithHttpMessagesAsync(uri, value, customHeaders, cancellationToken);
        }

        protected override Uri GetUri(params string[] values)
        {
            return BaseUri.Append("me", "roles");
        }
    }
}