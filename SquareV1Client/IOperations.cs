﻿//using Microsoft.Rest;
//using System.Collections.Generic;
//using System.Threading;
//using System.Threading.Tasks;

//namespace MeyerCorp.Square.V1
//{
//    /// <summary>
//    /// OrdersOperations operations.
//    /// </summary>
//    public partial interface IOperations<T, Tid>
//    {
//        ///// <param name='customHeaders'>
//        ///// The headers that will be added to request.
//        ///// </param>
//        ///// <param name='cancellationToken'>
//        ///// The cancellation token.
//        ///// </param>
//        //Task<HttpOperationResponse<IList<T>>> GetWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

//        /// <param name='id'>
//        /// </param>
//        /// <param name='value'>
//        /// </param>
//        /// <param name='customHeaders'>
//        /// The headers that will be added to request.
//        /// </param>
//        /// <param name='cancellationToken'>
//        /// The cancellation token.
//        /// </param>
//        Task<HttpOperationResponse> PutWithHttpMessagesAsync(Tid id, T value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

//        /// <param name='value'>
//        /// </param>
//        /// <param name='customHeaders'>
//        /// The headers that will be added to request.
//        /// </param>
//        /// <param name='cancellationToken'>
//        /// The cancellation token.
//        /// </param>
//        Task<HttpOperationResponse> PostWithHttpMessagesAsync(T value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

//        /// <param name='id'>
//        /// </param>
//        /// <param name='customHeaders'>
//        /// The headers that will be added to request.
//        /// </param>
//        /// <param name='cancellationToken'>
//        /// The cancellation token.
//        /// </param>
//        Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(Tid id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
//    }
//}
