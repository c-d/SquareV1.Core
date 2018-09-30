using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MeyerCorp.Square.V1.Subscription
{
    public static partial class PlanOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static ActiveList<SubscriptionPlan> Get(this IPlanOperations operations, string clientId)
        {
            return Task
                .Factory
                .StartNew(s => ((IPlanOperations)s).GetAsync(clientId),
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
        public static async Task<ActiveList<SubscriptionPlan>> GetAsync(this IPlanOperations operations,
            string clientId,
            bool isContinous = false,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var result = await operations.GetWithHttpMessagesAsync(clientId, null, cancellationToken).ConfigureAwait(false))
            {
                return new ActiveList<SubscriptionPlan>
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
        public static SubscriptionPlan Get(this IPlanOperations operations, string clientId, string planId)
        {
            return Task
                .Factory
                .StartNew(s => ((IPlanOperations)s).GetAsync(clientId, planId),
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
        public static async Task<SubscriptionPlan> GetAsync(this IPlanOperations operations,
            string clientId,
            string planId,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(clientId, planId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}