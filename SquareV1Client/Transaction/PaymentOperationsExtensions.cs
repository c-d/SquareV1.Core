using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Transaction
{
    public static partial class PaymentOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IEnumerable<Payment> Get(this IPaymentOperations operations, 
            string locationId, 
            DateTime? beginTime=null, 
            DateTime? endTime = null, 
            ListOrderType? listOrder = null, 
            short? limit = null, 
            bool isContinous=false)
        {
            //return new ActiveList<Payment>
            //{
            //    _Payments = Task
            //    .Factory
            //    .StartNew(s => ((IPaymentOperations)s).GetAsync(locationId, beginTime, endTime, listOrder, limit), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
            //    .Unwrap()
            //    .GetAwaiter()
            //    .GetResult(),
            //};

            var task = Task.Run(() => operations.GetWithHttpMessagesAsync(locationId, beginTime, endTime, listOrder, limit, null));

            task.Wait();

            return new ActiveEnumerable<Payment>
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
        public static async Task<IEnumerable<Payment>> GetAsync(this IPaymentOperations operations,
            string locationId,
            DateTime? beginTime = null,
            DateTime? endTime = null,
            ListOrderType? listOrder = null,
            short? limit = null,
            bool isContinous = false,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var result = await operations.GetWithHttpMessagesAsync(locationId, beginTime, endTime, listOrder, limit, null, cancellationToken).ConfigureAwait(false))
            {
                return new ActiveEnumerable<Payment>
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
