﻿using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Item
{
    public interface IPageOperations : IOperations
    {
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<Page>>> GetWithHttpMessagesAsync(string locationId,
            DateTime? beginTime = null,
            DateTime? endTime = null,
            ListOrderType? listOrder = null,
            short? limit = null,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Page>> GetWithHttpMessagesAsync(string locationId, string paymentId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='id'>
        /// </param>
        /// <param name='value'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PutWithHttpMessagesAsync(string locationId, Page value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='value'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PostWithHttpMessagesAsync(string locationId, Page value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='id'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string locationId, string paymentId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
