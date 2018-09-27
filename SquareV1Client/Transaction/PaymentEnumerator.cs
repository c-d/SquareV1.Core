using System;
using System.Collections.Generic;
using System.Threading;

namespace MeyerCorp.Square.V1.Transaction
{
    public class PaymentEnumerator : ActiveEnumerator<Payment>
    {
        public PaymentEnumerator(IList<Payment> payments,
            IPaymentOperations operations,
            string initialUri,
            string nextUri,
             bool isContinous = false,
           CancellationToken cancellationToken = default(CancellationToken))
            : base(payments, operations, initialUri, nextUri, isContinous, cancellationToken)
        { }
    }
}