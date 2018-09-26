using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Transaction
{
    public class PaymentEnumerator : IEnumerator<Payment>
    {
        IEnumerator<Payment> _Enumerator;
        Uri _NextUri;
        IList<Payment> _Payments;

        readonly IPaymentOperations _Operations;
        readonly CancellationToken _CancellationToken;

        public PaymentEnumerator(IList<Payment> payments, IPaymentOperations operations, Uri nextUri, CancellationToken cancellationToken = default(CancellationToken))
        {
            _Payments = payments;
            _Operations = operations;
            _NextUri = nextUri;
            _CancellationToken = cancellationToken;

            _Enumerator = _Payments.GetEnumerator();
        }

        public Payment Current => _Enumerator.Current;

        object IEnumerator.Current => _Enumerator.Current;

        public void Dispose() { if (_Enumerator != null) _Enumerator.Dispose(); }

        public bool MoveNext()
        {
            var result = _Enumerator.MoveNext();

            if (result)
                return result;
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

        void GetNewEnumerator()
        {
            var result = Task
                .Factory
                .StartNew(s => ((IOperations)s).GetWithHttpMessagesAsync<IList<Payment>>(_NextUri, null, _CancellationToken), _Operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                .Unwrap()
                .GetAwaiter()
                .GetResult();

            _NextUri = result.ToNextUri();
            _Payments = result.Body;
            _Enumerator = _Payments.GetEnumerator();
        }

        public void Reset() { _Enumerator.Reset(); }
    }
}