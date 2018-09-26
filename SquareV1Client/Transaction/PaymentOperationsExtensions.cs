using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Transaction
{
    public static partial class PaymentOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static PaymentList Get(this IPaymentOperations operations, string locationId, DateTime? beginTime=null, DateTime? endTime = null, RangeOrderType? dateRangeOrder = null, short? take = null)
        {
            //return new PaymentList
            //{
            //    _Payments = Task
            //    .Factory
            //    .StartNew(s => ((IPaymentOperations)s).GetAsync(locationId, beginTime, endTime, dateRangeOrder, take), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
            //    .Unwrap()
            //    .GetAwaiter()
            //    .GetResult(),
            //};

            var task = Task.Run(() => operations.GetWithHttpMessagesAsync(locationId, beginTime, endTime, dateRangeOrder, take, null));

            task.Wait();

            return new PaymentList
            {
                _Payments = task.Result.Body,
                _NextUri = task.Result.ToNextUri(),
                _Operations = operations,
            };
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IList<Payment>> GetAsync(this IPaymentOperations operations,
            string locationId,
            DateTime? beginTime = null,
            DateTime? endTime = null,
            RangeOrderType? dateRangeOrder = null,
            short? take = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var result = await operations.GetWithHttpMessagesAsync(locationId, beginTime, endTime, dateRangeOrder, take, null, cancellationToken).ConfigureAwait(false))
            {
                return result.Body;

                //return new PagedList<Payment>
                //{
                //    List = result.Body,
                //    Next = result.ToNextUri(),
                //};
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='value'>
        /// </param>
        public static void Put(this IPaymentOperations operations, string locationId, string paymentId, Payment value)
        {
            Task.Factory.StartNew(s => ((IPaymentOperations)s).PutAsync(locationId, paymentId, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
        public static async Task PutAsync(this IPaymentOperations operations, string locationId, string paymentId, Payment value, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.PutWithHttpMessagesAsync(locationId, value, null, cancellationToken).ConfigureAwait(false);
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        public static void Post(this IPaymentOperations operations, string locationId, Payment value)
        {
            Task.Factory.StartNew(s => ((IPaymentOperations)s).PostAsync(locationId, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task PostAsync(this IPaymentOperations operations, string locationId, Payment value, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.PostWithHttpMessagesAsync(locationId, value, null, cancellationToken).ConfigureAwait(false);
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        public static void Delete(this IPaymentOperations operations, string locationId, string paymentId)
        {
            Task.Factory.StartNew(s => ((IPaymentOperations)s).DeleteAsync(locationId, paymentId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task DeleteAsync(this IPaymentOperations operations, string locationId, string paymentId, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.DeleteWithHttpMessagesAsync(locationId, paymentId, null, cancellationToken).ConfigureAwait(false);
        }
    }
}
