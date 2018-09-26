namespace MeyerCorp.Square.V1.Transaction
{
    /// <summary>
    /// A refund's type.
    /// </summary>
    public enum RefundType
    {
        /// <summary>
        /// A partial refund.
        /// </summary>
        Partial = 0,

        /// <summary>
        /// A full refund.
        /// </summary>
        Full,
    }
}