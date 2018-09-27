using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Business
{
    public static partial class RoleOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IList<Role> Get(this IRoleOperations operations)
        {
            return Task.Factory.StartNew(s => ((IRoleOperations)s).GetAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IList<Role>> GetAsync(this IRoleOperations operations,
            ListOrderType? listOrder = null,
            short? limit = null,
                 bool isContinous = false,
       CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(listOrder,limit, isContinous, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Role Get(this IRoleOperations operations, string roleId)
        {
            return Task.Factory.StartNew(s => ((IRoleOperations)s).GetAsync(roleId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<Role> GetAsync(this IRoleOperations operations, string roleId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(roleId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        public static void Post(this IRoleOperations operations, Role value)
        {
            Task.Factory.StartNew(s => ((IRoleOperations)s).PostAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task PostAsync(this IRoleOperations operations, Role value, CancellationToken cancellationToken = default(CancellationToken))
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
        public static void Put(this IRoleOperations operations, string roleId, Role value)
        {
            Task.Factory.StartNew(s => ((IRoleOperations)s).PutAsync(roleId, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
        public static async Task PutAsync(this IRoleOperations operations, string roleId, Role value, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.PutWithHttpMessagesAsync(roleId, value, null, cancellationToken).ConfigureAwait(false);
        }

        ///// <param name='operations'>
        ///// The operations group for this extension method.
        ///// </param>
        ///// <param name='id'>
        ///// </param>
        //public static void Delete(this IRoleOperations operations, string roleId)
        //{
        //    Task.Factory.StartNew(s => ((IRoleOperations)s).DeleteAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        //}

        ///// <param name='operations'>
        ///// The operations group for this extension method.
        ///// </param>
        ///// <param name='id'>
        ///// </param>
        ///// <param name='cancellationToken'>
        ///// The cancellation token.
        ///// </param>
        //public static async Task DeleteAsync(this IRoleOperations operations, string roleId, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    await operations.DeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
        //}
    }
}
