using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Business
{
    public static partial class EmployeeOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IEnumerable<Employee> Get(this IEmployeeOperations operations,
            DateTime? created,
            DateTime? updated,
            EmployeeStatusType? status,
            string externalId,
            ListOrderType? listOrder = null,
            short? limit = null,
            bool isContinous = false)
        {
            //return Task
            //    .Factory
            //    .StartNew(s => ((IEmployeeOperations)s).GetAsync(created, updated, status, externalId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
            //    .Unwrap()
            //    .GetAwaiter()
            //    .GetResult();

            var task = Task.Run(() => operations.GetWithHttpMessagesAsync(created, updated, status, externalId, listOrder, limit, isContinous, null));

            task.Wait();

            return new ActiveEnumerable<Employee>
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
        public static async Task<IList<Employee>> GetAsync(this IEmployeeOperations operations,
            DateTime? created,
            DateTime? updated,
            EmployeeStatusType? status,
            string externalId,
            ListOrderType? listOrder = null,
            short? limit = null,
            bool isContinous = false,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(created, updated, status, externalId, listOrder, limit, isContinous, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Employee Get(this IEmployeeOperations operations, string employeeId)
        {
            return Task.Factory.StartNew(s => ((IEmployeeOperations)s).GetAsync(employeeId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<Employee> GetAsync(this IEmployeeOperations operations, string employeeId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(employeeId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        public static void Post(this IEmployeeOperations operations, Employee value)
        {
            Task.Factory.StartNew(s => ((IEmployeeOperations)s).PostAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task PostAsync(this IEmployeeOperations operations, Employee value, CancellationToken cancellationToken = default(CancellationToken))
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
        public static void Put(this IEmployeeOperations operations, string employeeId, Employee value)
        {
            Task.Factory.StartNew(s => ((IEmployeeOperations)s).PutAsync(employeeId, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
        public static async Task PutAsync(this IEmployeeOperations operations, string employeeId, Employee value, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.PutWithHttpMessagesAsync(employeeId, value, null, cancellationToken).ConfigureAwait(false);
        }

        ///// <param name='operations'>
        ///// The operations group for this extension method.
        ///// </param>
        ///// <param name='id'>
        ///// </param>
        //public static void Delete(this IEmployeeOperations operations, string employeeId)
        //{
        //    Task.Factory.StartNew(s => ((IEmployeeOperations)s).DeleteAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        //}

        ///// <param name='operations'>
        ///// The operations group for this extension method.
        ///// </param>
        ///// <param name='id'>
        ///// </param>
        ///// <param name='cancellationToken'>
        ///// The cancellation token.
        ///// </param>
        //public static async Task DeleteAsync(this IEmployeeOperations operations, string employeeId, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    await operations.DeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
        //}
    }
}
