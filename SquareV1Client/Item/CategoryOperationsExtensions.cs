using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Item
{
    public static partial class CategoryOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IEnumerable<Category>> GetAsync(this ICategoryOperations operations,
            string locationId,
            bool isContinous = false,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var result = await operations.GetWithHttpMessagesAsync(locationId, isContinous, null, cancellationToken).ConfigureAwait(false))
            {
                return new ActiveEnumerable<Category>
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
        public static void Put(this ICategoryOperations operations, string locationId, string id, Category value)
        {
            Task.Factory.StartNew(s => ((ICategoryOperations)s).PutAsync(locationId, id, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
        public static async Task PutAsync(this ICategoryOperations operations, string locationId, string id, Category value, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.PutWithHttpMessagesAsync(locationId,id, value, null, cancellationToken).ConfigureAwait(false);
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        public static void Post(this ICategoryOperations operations, string locationId, Category value)
        {
            Task.Factory.StartNew(s => ((ICategoryOperations)s).PostAsync(locationId, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task PostAsync(this ICategoryOperations operations, string locationId, Category value, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.PostWithHttpMessagesAsync(locationId, value, null, cancellationToken).ConfigureAwait(false);
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        public static void Delete(this ICategoryOperations operations, string locationId, string id)
        {
            Task.Factory.StartNew(s => ((ICategoryOperations)s).DeleteAsync(locationId, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task DeleteAsync(this ICategoryOperations operations, string locationId, string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.DeleteWithHttpMessagesAsync(locationId, id, null, cancellationToken).ConfigureAwait(false);
        }
    }
}
