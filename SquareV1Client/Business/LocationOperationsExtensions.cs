using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Business
{
    public static partial class LocationOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IEnumerable<Merchant> Get(this ILocationOperations operations)
        {
            return Task
                .Factory
                .StartNew(s => ((ILocationOperations)s).GetAsync(), 
                    operations, 
                    CancellationToken.None, 
                    TaskCreationOptions.None, 
                    TaskScheduler.Default).Unwrap()
                .GetAwaiter()
                .GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IEnumerable<Merchant>> GetAsync(this ILocationOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
