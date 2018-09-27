using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Business
{
    public static partial class CashDrawerShiftOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IList<CashDrawerShift> Get(this ICashDrawerShiftOperations operations,
            string locationId,
            ListOrderType? order = null,
            DateTime? beginTime = null,
            DateTime? endTime = null)
        {
            //return Task.Factory.StartNew(s => ((ICashDrawerShiftOperations)s).GetAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();

            var task = Task.Run(() => operations.GetWithHttpMessagesAsync(locationId, order, beginTime, endTime, null));

            task.Wait();

            return task.Result.Body;
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IList<CashDrawerShift>> GetAsync(this ICashDrawerShiftOperations operations,
            string locationId,
            ListOrderType? order = null,
            DateTime? beginTime = null,
            DateTime? endTime = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(locationId, order, beginTime, endTime, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static CashDrawerShift Get(this ICashDrawerShiftOperations operations, string locationId, string id)
        {
            return Task.Factory.StartNew(s => ((ICashDrawerShiftOperations)s).GetAsync(locationId, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<CashDrawerShift> GetAsync(this ICashDrawerShiftOperations operations, string locationId, string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(locationId, id, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
