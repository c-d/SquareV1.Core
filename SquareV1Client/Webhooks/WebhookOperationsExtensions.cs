using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MeyerCorp.Square.V1.Webhooks
{
    public static partial class WebhookOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IList<WebhookEventType> Get(this IWebhookOperations operations,
            string locationId,
            string id,
            bool isContinous = false)
        {
            //return new ActiveList<Webhook>
            //{
            //    _Webhooks = Task
            //    .Factory
            //    .StartNew(s => ((IWebhookOperations)s).GetAsync(locationId, beginTime, endTime, listOrder, limit), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
            //    .Unwrap()
            //    .GetAwaiter()
            //    .GetResult(),
            //};

            var task = Task.Run(() => operations.GetWithHttpMessagesAsync(locationId));

            task.Wait();

            return new ActiveList<Webhook>
            {
                InitialUri = task.Result.Request.RequestUri.AbsoluteUri,
                Collection = task.Result.Body,
                NextUri = task.Result.ToNextUri(),
                Operations = operations,
                IsContinous = isContinous,
            };
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IList<WebhookEventType>> GetAsync(this IWebhookOperations operations,
            string locationId,
            bool isContinous = false,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var result = await operations.GetWithHttpMessagesAsync(locationId, null, cancellationToken).ConfigureAwait(false))
            {
                return new ActiveList<Webhook>
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
        /// <param name='id'>
        /// </param>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IList<WebhookEventType>> PutAsync(this IWebhookOperations operations,
            string locationId,
            IEnumerable<WebhookEventType> value,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var result = await operations.PutWithHttpMessagesAsync(locationId, value, null, cancellationToken).ConfigureAwait(false))
            {
                return new List<WebhookEventType>(result.Body);
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        public static IList<WebhookEventType> Put(this IWebhookOperations operations, string locationId, IEnumerable<WebhookEventType> value)
        {
            return Task
                  .Factory
                  .StartNew(s => ((IWebhookOperations)s).PutAsync(locationId, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                  .Unwrap()
                  .GetAwaiter()
                  .GetResult();
        }
    }
}