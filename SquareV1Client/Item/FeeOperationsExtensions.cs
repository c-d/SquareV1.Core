using System;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Item
{
    public static partial class FeeOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static ActiveList<Fee> Get(this IFeeOperations operations,
            string locationId,
            bool isContinous = false)
        {
            //return new ActiveList<Fee>
            //{
            //    _Fees = Task
            //    .Factory
            //    .StartNew(s => ((IFeeOperations)s).GetAsync(locationId, beginTime, endTime, listOrder, limit), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
            //    .Unwrap()
            //    .GetAwaiter()
            //    .GetResult(),
            //};

            var task = Task.Run(() => operations.GetWithHttpMessagesAsync(locationId, null));

            task.Wait();

            return new ActiveList<Fee>
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
        /// <param name='id'>
        /// </param>
        /// <param name='value'>
        /// </param>
        public static void Put(this IFeeOperations operations, string locationId, string id, Fee value)
        {
            Task.Factory.StartNew(s => ((IFeeOperations)s).PutAsync(locationId, id, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
        public static async Task PutAsync(this IFeeOperations operations, string locationId, string id, Fee value, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.PutWithHttpMessagesAsync(locationId, id, value, null, cancellationToken).ConfigureAwait(false);
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        public static void Post(this IFeeOperations operations, string locationId, Fee value)
        {
            Task.Factory.StartNew(s => ((IFeeOperations)s).PostAsync(locationId, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task PostAsync(this IFeeOperations operations, string locationId, Fee value, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.PostWithHttpMessagesAsync(locationId, value, null, cancellationToken).ConfigureAwait(false);
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        public static void Delete(this IFeeOperations operations, string locationId, string id)
        {
            Task.Factory.StartNew(s => ((IFeeOperations)s).DeleteAsync(locationId, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task DeleteAsync(this IFeeOperations operations, string locationId, string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.DeleteWithHttpMessagesAsync(locationId, id, null, cancellationToken).ConfigureAwait(false);
        }
    }
}
