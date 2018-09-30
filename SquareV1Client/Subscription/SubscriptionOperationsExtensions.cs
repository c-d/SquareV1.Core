using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Subscription
{
    public static partial class SubscriptionOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static ActiveList<Subscription> Get(this ISubscriptionOperations operations, string clientId,
            string merchantId,
            short? limit,
            bool isContinous = false)
        {
            return Task
                .Factory
                .StartNew(s => ((ISubscriptionOperations)s).GetAsync(clientId, merchantId, limit),
                    operations,
                    CancellationToken.None,
                    TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ActiveList<Subscription>> GetAsync(this ISubscriptionOperations operations,
            string clientId,
            string merchantId,
            short? limit,
            bool isContinous = false,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var result = await operations.GetWithHttpMessagesAsync(clientId, merchantId, limit, null, cancellationToken).ConfigureAwait(false))
            {
                return new ActiveList<Subscription>
                {
                    InitialUri = result.Request.RequestUri.AbsoluteUri,
                    Collection = result.Body,
                    NextUri = result.ToNextUri(),
                    Operations = operations,
                    IsContinous = isContinous,
                    CancellationToken = cancellationToken,
                };
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Subscription Get(this ISubscriptionOperations operations, string clientId, string subscriptionId)
        {
            return Task
                .Factory
                .StartNew(s => ((ISubscriptionOperations)s).GetAsync(clientId, subscriptionId),
                    operations,
                    CancellationToken.None,
                    TaskCreationOptions.None,
                    TaskScheduler.Default)
                .Unwrap()
                .GetAwaiter()
                .GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<Subscription> GetAsync(this ISubscriptionOperations operations,
            string clientId,
            string subscriptionId,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(clientId, subscriptionId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}