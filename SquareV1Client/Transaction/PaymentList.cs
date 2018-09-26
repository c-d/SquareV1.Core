using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace MeyerCorp.Square.V1.Transaction
{
    public class PaymentList : IList<Payment>
    {
        internal IList<Payment> _Payments { get; set; }
        internal Uri _NextUri { get; set; }
        internal IPaymentOperations _Operations { get; set; }
        internal CancellationToken _CancellationToken { get; set; } = default(CancellationToken);

        public Payment this[int index] { get => _Payments[index]; set => _Payments[index] = value; }

        public int Count => _Payments.Count;

        public bool IsReadOnly => true;

        public void Add(Payment item) { throw new NotSupportedException(); }

        public void Clear() { throw new NotSupportedException(); }

        public bool Contains(Payment item) { return _Payments.Contains(item); }

        public void CopyTo(Payment[] array, int arrayIndex) { _Payments.CopyTo(array, arrayIndex); }

        public IEnumerator<Payment> GetEnumerator()
        {
            return new PaymentEnumerator(_Payments, _Operations, _NextUri, _CancellationToken);
            //_Payments.GetEnumerator(); 
        }

        public int IndexOf(Payment item) { return _Payments.IndexOf(item); }

        public void Insert(int index, Payment item) { _Payments.Insert(index, item); }

        public bool Remove(Payment item) { return _Payments.Remove(item); }

        public void RemoveAt(int index) { _Payments.RemoveAt(index); }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PaymentEnumerator(_Payments, _Operations, _NextUri, _CancellationToken);
            //return _Payments.GetEnumerator(); }
        }
    }
}