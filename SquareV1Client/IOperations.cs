using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1
{
    /// <summary>
    /// OrdersOperations operations.
    /// </summary>
    public partial interface IOperations
    {
        Task<HttpOperationResponse<T>> GetWithHttpMessagesAsync<T>(Uri uri,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}
