using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Net.Http;
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

        public async Task<HttpOperationResponse<IList<Role>>> GetWithHttpMessagesAsync(DateRangeOrderType? dateRangeOrder = null,
            short? take = null,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("GET"),
                RequestUri = GetUri().AppendOrderOrLimit(take, dateRangeOrder),
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

            return await DeserializeResponseAsync<IList<Role>>(statusCode, httpRequest, httpResponse);
        }

        public Task<HttpOperationResponse<Role>> GetWithHttpMessagesAsync(string roleId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetWithHttpMessagesAsync<Role>(GetUri().Append(roleId), customHeaders, cancellationToken);
        }

        public async Task<HttpOperationResponse> PostWithHttpMessagesAsync(Role value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (value == null) throw new ValidationException(ValidationRules.CannotBeNull, "value");

            // Create HTTP transport objects
            var httpRequest = new HttpRequestMessage
            {
                Method = new HttpMethod("POST"),
                RequestUri = GetUri(),
            };

            SetHeaders(httpRequest, customHeaders);
            var requestcontent = SerializeRequest<Role>(value, httpRequest);
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

        public async Task<HttpOperationResponse> PutWithHttpMessagesAsync(string roleId, Role value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
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
            throw new NotSupportedException();
        }

        protected override Uri GetUri(params string[] values)
        {
            return BaseUri.Append("me", "roles");
        }
    }
}