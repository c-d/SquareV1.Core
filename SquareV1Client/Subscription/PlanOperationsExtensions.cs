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
        public static IList<SubscriptionPlan> Get(this IPlanOperations operations,
            string locationId,
            string id,
            bool isContinous = false)
        {
            return Task
                .Factory
                .StartNew(s => ((IPlanOperations)s).GetAsync(locationId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
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
        public static async Task<IList<SubscriptionPlan>> GetAsync(this IPlanOperations operations,
            string locationId,
            bool isContinous = false,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var result = await operations.GetWithHttpMessagesAsync(locationId, null, cancellationToken).ConfigureAwait(false))
            {
                return result.Body;
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IList<SubscriptionPlan>> PutAsync(this IPlanOperations operations,
            string locationId,
            IEnumerable<SubscriptionPlan> value,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var result = await operations.PutWithHttpMessagesAsync(locationId, value, null, cancellationToken).ConfigureAwait(false))
            {
                return new List<SubscriptionPlan>(result.Body);
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        public static IList<SubscriptionPlan> Put(this IPlanOperations operations, string locationId, IEnumerable<SubscriptionPlan> value)
        {
            return Task
                  .Factory
                  .StartNew(s => ((IPlanOperations)s).PutAsync(locationId, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                  .Unwrap()
                  .GetAwaiter()
                  .GetResult();
        }
    }
}