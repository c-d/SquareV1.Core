namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Indicates the type of adjustment a fee applies to a payment.
    /// </summary>
    /// <remarks>
    /// Currently, this value is TAX for all fees.
    /// </remarks>
    public enum FeeAdjustmentType
    {
        /// <summary>
        /// The fee is a tax.
        /// </summary>
        Tax
    }
}
