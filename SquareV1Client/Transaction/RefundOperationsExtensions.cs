using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Transaction
{
    public static partial class RefundOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IEnumerable<Refund> Get(this IRefundOperations operations,
            string locationId,
            DateTime? beginTime = null,
            DateTime? endTime = null,
            ListOrderType? listOrder = null,
            short? limit = null,
            bool isContinous = false)
        {
            //return new ActiveList<Refund>
            //{
            //    _Refunds = Task
            //    .Factory
            //    .StartNew(s => ((IRefundOperations)s).GetAsync(locationId, beginTime, endTime, listOrder, limit), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
            //    .Unwrap()
            //    .GetAwaiter()
            //    .GetResult(),
            //};

            var task = Task.Run(() => operations.GetWithHttpMessagesAsync(locationId, beginTime, endTime, listOrder, limit, null));

            task.Wait();

            return new ActiveEnumerable<Refund>
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
        public static async Task<IList<Refund>> GetAsync(this IRefundOperations operations,
            string locationId,
            DateTime? beginTime = null,
            DateTime? endTime = null,
            ListOrderType? listOrder = null,
            short? limit = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var result = await operations.GetWithHttpMessagesAsync(locationId,beginTime, endTime, listOrder,limit, null, cancellationToken).ConfigureAwait(false))
            {
                return new List<Refund>(result.Body);
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        public static void Post(this IRefundOperations operations, string locationId, Refund value)
        {
            Task.Factory.StartNew(s => ((IRefundOperations)s).PostAsync(locationId, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task PostAsync(this IRefundOperations operations, string locationId, Refund value, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.PostWithHttpMessagesAsync(locationId, value, null, cancellationToken).ConfigureAwait(false);
        }
    }
}
