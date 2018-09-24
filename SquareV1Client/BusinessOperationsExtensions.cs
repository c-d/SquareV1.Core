using MeyerCorp.Square.V1.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1
{
    public static partial class BusinessOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Merchant Get(this IBusinessOperations operations)
        {
            return Task.Factory.StartNew(s => ((IBusinessOperations)s).GetAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<Merchant> GetAsync(this IBusinessOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Merchant Get(this IBusinessOperations operations, string locationId)
        {
            return Task.Factory.StartNew(s => ((IBusinessOperations)s).GetAsync(locationId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<Merchant> GetAsync(this IBusinessOperations operations, string locationId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(locationId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        ///// <param name='operations'>
        ///// The operations group for this extension method.
        ///// </param>
        ///// <param name='id'>
        ///// </param>
        ///// <param name='value'>
        ///// </param>
        //public static void Put(this IBusinessOperations operations, int id, Merchant value)
        //{
        //    Task.Factory.StartNew(s => ((IBusinessOperations)s).PutAsync(id, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        //}

        ///// <param name='operations'>
        ///// The operations group for this extension method.
        ///// </param>
        ///// <param name='id'>
        ///// </param>
        ///// <param name='value'>
        ///// </param>
        ///// <param name='cancellationToken'>
        ///// The cancellation token.
        ///// </param>
        //public static async Task PutAsync(this IBusinessOperations operations, int id, Merchant value, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    await operations.PutWithHttpMessagesAsync(id, value, null, cancellationToken).ConfigureAwait(false);
        //}

        ///// <param name='operations'>
        ///// The operations group for this extension method.
        ///// </param>
        ///// <param name='value'>
        ///// </param>
        //public static void Post(this IBusinessOperations operations, Merchant value)
        //{
        //    Task.Factory.StartNew(s => ((IBusinessOperations)s).PostAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        //}

        ///// <param name='operations'>
        ///// The operations group for this extension method.
        ///// </param>
        ///// <param name='value'>
        ///// </param>
        ///// <param name='cancellationToken'>
        ///// The cancellation token.
        ///// </param>
        //public static async Task PostAsync(this IBusinessOperations operations, Merchant value, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    await operations.PostWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false);
        //}

        ///// <param name='operations'>
        ///// The operations group for this extension method.
        ///// </param>
        ///// <param name='id'>
        ///// </param>
        //public static void Delete(this IBusinessOperations operations, int id)
        //{
        //    Task.Factory.StartNew(s => ((IBusinessOperations)s).DeleteAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        //}

        ///// <param name='operations'>
        ///// The operations group for this extension method.
        ///// </param>
        ///// <param name='id'>
        ///// </param>
        ///// <param name='cancellationToken'>
        ///// The cancellation token.
        ///// </param>
        //public static async Task DeleteAsync(this IBusinessOperations operations, int id, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    await operations.DeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
        //}
    }
}
