namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Indicates whether a fee is calculated based on a payment's subtotal or total.
    /// </summary>
    public enum FeeCalculationPhaseType
    {
        /// <summary>
        /// The fee is calculated based on the payment's subtotal.
        /// </summary>
        FeeSubTotalPhase,

        /// <summary>
        /// The fee is calculated based on the payment's total.
        /// </summary>
        FeeTotalPhase,

        /// <summary>
        /// A calculation phase that does not match any other value.
        /// </summary>
        Other
    }
}
