using System;
using System.Collections.Generic;
using System.Threading;

namespace MeyerCorp.Square.V1.Item
{
    public class ItemEnumerator : ActiveEnumerator<Item>
    {
        public ItemEnumerator(IList<Item> payments,
            IItemOperations operations,
            Uri nextUri,
            CancellationToken cancellationToken = default(CancellationToken))
            : base(payments, operations, nextUri, cancellationToken)
        { }
    }
}