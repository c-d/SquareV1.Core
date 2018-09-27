using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace MeyerCorp.Square.V1.Transaction
{
    public class PaymentList : IList<Payment>
    {
        internal IList<Payment> Payments { get; set; }
        internal string InitialUri { get; set; }
        internal string NextUri { get; set; }
        internal IPaymentOperations Operations { get; set; }
        internal CancellationToken CancellationToken { get; set; } = default(CancellationToken);
        internal bool IsContinous { get; set; }

        public Payment this[int index] { get => Payments[index]; set => Payments[index] = value; }

        public int Count => Payments.Count;

        public bool IsReadOnly => true;

        public void Add(Payment item) { throw new NotSupportedException(); }

        public void Clear() { throw new NotSupportedException(); }

        public bool Contains(Payment item) { return Payments.Contains(item); }

        public void CopyTo(Payment[] array, int arrayIndex) { Payments.CopyTo(array, arrayIndex); }

        public IEnumerator<Payment> GetEnumerator()
        {
            return new PaymentEnumerator(Payments, Operations, InitialUri, NextUri, IsContinous, CancellationToken);
        }

        public int IndexOf(Payment item) { return Payments.IndexOf(item); }

        public void Insert(int index, Payment item) { Payments.Insert(index, item); }

        public bool Remove(Payment item) { return Payments.Remove(item); }

        public void RemoveAt(int index) { Payments.RemoveAt(index); }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PaymentEnumerator(Payments, Operations, InitialUri, NextUri, IsContinous, CancellationToken);
        }
    }
}