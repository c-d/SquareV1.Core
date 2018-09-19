using MeyerCorp.Square.V1.Models;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1
{
    public interface IPaymentOperations : IOperations<Payment>
    {
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<Payment>>> GetWithHttpMessagesAsync(DateTime beginTime,
            DateTime endTime,
            DateRangeOrderType dateRangeOrder = DateRangeOrderType.Descending,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}
