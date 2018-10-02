using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Item
{
    public static partial class ModifierListOperationsExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IEnumerable<ModifierList>> GetAsync(this IModifierListOperations operations,
            string locationId,
            bool isContinous = false,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var result = await operations.GetWithHttpMessagesAsync(locationId, null, cancellationToken).ConfigureAwait(false))
            {
                return new ActiveEnumerable<ModifierList>
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
        public static IEnumerable<ModifierList> Get(this IModifierListOperations operations,
            string locationId,
            bool isContinous = false)
        {
            //return new ActiveList<ModifierList>
            //{
            //    _ModifierLists = Task
            //    .Factory
            //    .StartNew(s => ((IModifierListOperations)s).GetAsync(locationId, beginTime, endTime, listOrder, limit), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
            //    .Unwrap()
            //    .GetAwaiter()
            //    .GetResult(),
            //};

            var task = Task.Run(() => operations.GetWithHttpMessagesAsync(locationId));

            task.Wait();

            return new ActiveEnumerable<ModifierList>
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
        public static ModifierList Get(this IModifierListOperations operations, string locationId, string id)
        {
            return Task.Factory.StartNew(s => ((IModifierListOperations)s).GetAsync(locationId, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ModifierList> GetAsync(this IModifierListOperations operations, string locationId, string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(locationId, id, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='value'>
        /// </param>
        public static void Put(this IModifierListOperations operations, string locationId, string id, ModifierList value)
        {
            Task.Factory.StartNew(s => ((IModifierListOperations)s).PutAsync(locationId, id, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
        public static async Task PutAsync(this IModifierListOperations operations, string locationId, string id, ModifierList value, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.PutWithHttpMessagesAsync(locationId,id, value, null, cancellationToken).ConfigureAwait(false);
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        public static void Post(this IModifierListOperations operations, string locationId, ModifierList value)
        {
            Task.Factory.StartNew(s => ((IModifierListOperations)s).PostAsync(locationId, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task PostAsync(this IModifierListOperations operations, string locationId, ModifierList value, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.PostWithHttpMessagesAsync(locationId, value, null, cancellationToken).ConfigureAwait(false);
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        public static void Delete(this IModifierListOperations operations, string locationId, string id)
        {
            Task.Factory.StartNew(s => ((IModifierListOperations)s).DeleteAsync(locationId, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task DeleteAsync(this IModifierListOperations operations, string locationId, string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            await operations.DeleteWithHttpMessagesAsync(locationId, id, null, cancellationToken).ConfigureAwait(false);
        }
    }
}
