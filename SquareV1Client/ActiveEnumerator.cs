using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1
{
    public abstract class ActiveEnumerator<T> : IEnumerator<T>
    {
        IEnumerator<T> _Enumerator;
        Uri _NextUri;
        IList<T> _Collection;

        readonly IOperations _Operations;
        readonly CancellationToken _CancellationToken;

        public ActiveEnumerator(IList<T> collection, IOperations operations, Uri nextUri, CancellationToken cancellationToken = default(CancellationToken))
        {
            _Collection = collection;
            _Operations = operations;
            _NextUri = nextUri;
            _CancellationToken = cancellationToken;

            _Enumerator = _Collection.GetEnumerator();
        }

        public T Current => _Enumerator.Current;

        object IEnumerator.Current => _Enumerator.Current;

        public void Dispose() { if (_Enumerator != null) _Enumerator.Dispose(); }

        public bool MoveNext()
        {
            if (_Enumerator.MoveNext())
                return true;
            else
            {
                if (_NextUri == null)
                    return false;
                else
                {
                    GetNewEnumerator();

                    return _Enumerator.MoveNext();
                }
            }
        }

        public void Reset() { _Enumerator.Reset(); }

        void GetNewEnumerator()
        {
            var result = Task
                .Factory
                .StartNew(s => ((IOperations)s).GetWithHttpMessagesAsync<IList<T>>(_NextUri, null, _CancellationToken), _Operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                .Unwrap()
                .GetAwaiter()
                .GetResult();

            _NextUri = result.ToNextUri();
            _Collection = result.Body;
            _Enumerator = _Collection.GetEnumerator();
        }
    }
}
