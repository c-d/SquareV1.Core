using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Batching
{
    public class BatchOperations : Operations, IBatchOperations
    {
        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public BatchOperations(Client client) : base(client) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns>https://connect.squareup.com/v1/{{location_id}}/payments</returns>
        protected override Uri GetUri(params string[] values)
        {
            switch (values.Length)
            {
                case 1: return BaseUri.Append("batch");
                default: throw new ArgumentException();
            }
        }

        public Task<HttpOperationResponse<BatchResponse>> PostWithHttpMessagesAsync(BatchRequest value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri();

            return PostWithHttpMessagesAsync<BatchResponse>(uri, value, customHeaders, cancellationToken);
        }
    }
}