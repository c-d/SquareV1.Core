using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Business
{
    public static partial class TimecardOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IList<Timecard> Get(this ITimecardOperations operations,
            ListOrderType? order = null,
            string employeeId = null,
            DateTime? beginClockIn = null,
            DateTime? endClockIn = null,
            DateTime? beginClockOut = null,
            DateTime? endClockOut = null,
            DateTime? beginUpdated = null,
            DateTime? endUpdated = null,
            bool? isDeleted = null,
            short? limit = null,
            bool isContinous = false)
        {
            //return Task.Factory.StartNew(s => ((ITimecardOperations)s).GetAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();

            var task = Task.Run(() => operations.GetWithHttpMessagesAsync(order, employeeId, beginClockIn, endClockIn, beginClockOut, endClockOut, beginUpdated, endUpdated, isDeleted, limit, isContinous, null));

            task.Wait();

            return new ActiveList<Timecard>
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
        public static async Task<IList<Timecard>> GetAsync(this ITimecardOperations operations,
            ListOrderType? order = null,
            string employeeId = null,
            DateTime? beginClockIn = null,
            DateTime? endClockIn = null,
            DateTime? beginClockOut = null,
            DateTime? endClockOut = null,
            DateTime? beginUpdated = null,
            DateTime? endUpdated = null,
            bool? isDeleted = null,
            short? limit = null,
            bool isContinous = false,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(order, employeeId, beginClockIn, endClockIn, beginClockOut, endClockOut, beginUpdated, endUpdated, isDeleted, limit, isContinous, null, cancellationToken).ConfigureAwait(false))
            {
                return new ActiveList<Timecard>
                {
                    InitialUri = _result.Request.RequestUri.AbsoluteUri,
                    Collection = _result.Body,
                    NextUri = _result.ToNextUri(),
                    Operations = operations,
                    IsContinous = isContinous,
                };
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Timecard Get(this ITimecardOperations operations, string id)
        {
            return Task.Factory.StartNew(s => ((ITimecardOperations)s).GetAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<Timecard> GetAsync(this ITimecardOperations operations, string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        public static void Post(this ITimecardOperations operations, Timecard value)
        {
            Task.Factory.StartNew(s => ((ITimecardOperations)s).PostAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task PostAsync(this ITimecardOperations operations, Timecard value, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.PostWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false);
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='value'>
        /// </param>
        public static void Put(this ITimecardOperations operations, string id, Timecard value)
        {
            Task.Factory.StartNew(s => ((ITimecardOperations)s).PutAsync(id, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
        public static async Task PutAsync(this ITimecardOperations operations, string id, Timecard value, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.PutWithHttpMessagesAsync(id, value, null, cancellationToken).ConfigureAwait(false);
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        public static void Delete(this ITimecardOperations operations, string id)
        {
            Task.Factory.StartNew(s => ((ITimecardOperations)s).DeleteAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task DeleteAsync(this ITimecardOperations operations, string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.DeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
        }
    }
}
