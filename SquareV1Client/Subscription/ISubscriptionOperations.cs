﻿using Microsoft.Rest;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Subscription
{
    public interface ISubscriptionOperations : IOperations
    {
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<Subscription>>> GetWithHttpMessagesAsync(string clientId,
            string merchantId = null,
            short? limit = null,
         Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Subscription>> GetWithHttpMessagesAsync(string clientId,
           string subscriptionId,
           Dictionary<string, List<string>> customHeaders = null,
           CancellationToken cancellationToken = default(CancellationToken));
    }
}
