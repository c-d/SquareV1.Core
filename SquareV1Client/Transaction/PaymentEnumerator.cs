﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace MeyerCorp.Square.V1.Transaction
{
    public class PaymentEnumerator : ActiveEnumerator<Payment>
    {
        public PaymentEnumerator(IList<Payment> payments,
            IPaymentOperations operations,
            Uri nextUri,
            CancellationToken cancellationToken = default(CancellationToken))
            : base(payments, operations, nextUri, cancellationToken)
        {}
    }
}