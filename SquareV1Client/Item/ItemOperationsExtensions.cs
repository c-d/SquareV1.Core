using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Item
{
    public static partial class ItemOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IList<Item> Get(this IItemOperations operations,
            string locationId,
            string id,
            bool isContinous = false)
        {
            //return new ActiveList<Item>
            //{
            //    _Items = Task
            //    .Factory
            //    .StartNew(s => ((IItemOperations)s).GetAsync(locationId, beginTime, endTime, listOrder, limit), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
            //    .Unwrap()
            //    .GetAwaiter()
            //    .GetResult(),
            //};

            var task = Task.Run(() => operations.GetWithHttpMessagesAsync(locationId));

            task.Wait();

            return new ActiveList<Item>
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
        public static async Task<IList<Item>> GetAsync(this IItemOperations operations,
            string locationId,
            bool isContinous = false,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var result = await operations.GetWithHttpMessagesAsync(locationId, null, cancellationToken).ConfigureAwait(false))
            {
                return new ActiveList<Item>
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
        public static void Put(this IItemOperations operations, string locationId, string id, Item value)
        {
            Task.Factory.StartNew(s => ((IItemOperations)s).PutAsync(locationId, id, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
        public static async Task PutAsync(this IItemOperations operations, string locationId, string id, Item value, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.PutWithHttpMessagesAsync(locationId, id, value, null, cancellationToken).ConfigureAwait(false);
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        public static void Post(this IItemOperations operations, string locationId, Item value)
        {
            Task.Factory.StartNew(s => ((IItemOperations)s).PostAsync(locationId, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task PostAsync(this IItemOperations operations, string locationId, Item value, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.PostWithHttpMessagesAsync(locationId, value, null, cancellationToken).ConfigureAwait(false);
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        public static void Delete(this IItemOperations operations, string locationId, string id)
        {
            Task.Factory.StartNew(s => ((IItemOperations)s).DeleteAsync(locationId, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task DeleteAsync(this IItemOperations operations, string locationId, string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.DeleteWithHttpMessagesAsync(locationId, id, null, cancellationToken).ConfigureAwait(false);
        }
    }
}
