using System.Collections.Generic;
using System.Threading;

namespace MeyerCorp.Square.V1.Item
{
    public class ItemEnumerator : ActiveEnumerator<Item>
    {
        public ItemEnumerator(IList<Item> payments,
            IItemOperations operations,
            string initialUri,
            string nextUri,
            bool isContinous = false,
            CancellationToken cancellationToken = default(CancellationToken))
            : base(payments, operations, initialUri, nextUri, isContinous, cancellationToken)
        { }
    }
}