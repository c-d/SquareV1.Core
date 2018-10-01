using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Business
{
    public static partial class LocationOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IList<Merchant> Get(this ILocationOperations operations)
        {
            return Task
                .Factory
                .StartNew(s => ((ILocationOperations)s).GetAsync(), 
                    operations, 
                    CancellationToken.None, 
                    TaskCreationOptions.None, 
                    TaskScheduler.Default).Unwrap()
                .GetAwaiter()
                .GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IList<Merchant>> GetAsync(this ILocationOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
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
        //public static void Put(this ILocationOperations operations, int id, Merchant value)
        //{
        //    Task.Factory.StartNew(s => ((ILocationOperations)s).PutAsync(id, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
        //public static async Task PutAsync(this ILocationOperations operations, int id, Merchant value, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    await operations.PutWithHttpMessagesAsync(id, value, null, cancellationToken).ConfigureAwait(false);
        //}

        ///// <param name='operations'>
        ///// The operations group for this extension method.
        ///// </param>
        ///// <param name='value'>
        ///// </param>
        //public static void Post(this ILocationOperations operations, Merchant value)
        //{
        //    Task.Factory.StartNew(s => ((ILocationOperations)s).PostAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        //}

        ///// <param name='operations'>
        ///// The operations group for this extension method.
        ///// </param>
        ///// <param name='value'>
        ///// </param>
        ///// <param name='cancellationToken'>
        ///// The cancellation token.
        ///// </param>
        //public static async Task PostAsync(this ILocationOperations operations, Merchant value, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    await operations.PostWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false);
        //}

        ///// <param name='operations'>
        ///// The operations group for this extension method.
        ///// </param>
        ///// <param name='id'>
        ///// </param>
        //public static void Delete(this ILocationOperations operations, int id)
        //{
        //    Task.Factory.StartNew(s => ((ILocationOperations)s).DeleteAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        //}

        ///// <param name='operations'>
        ///// The operations group for this extension method.
        ///// </param>
        ///// <param name='id'>
        ///// </param>
        ///// <param name='cancellationToken'>
        ///// The cancellation token.
        ///// </param>
        //public static async Task DeleteAsync(this ILocationOperations operations, int id, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    await operations.DeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
        //}
    }
}
