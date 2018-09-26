namespace MeyerCorp.Square.V1.Item
{
    /// <summary>
    /// Indicates whether a discount's value is fixed or entered at the time of sale.
    /// </summary>
    public enum DiscountType
    {
        /// <summary>
        /// The discount has a fixed value.
        /// </summary>
        Fixed = 0,

        /// <summary>
        /// The discount is percentage-based and entered at the time of sale.
        /// </summary>
        VariablePercentage,

        /// <summary>
        /// The discount is amount-based and entered at the time of sale.
        /// </summary>
        VariableAmount
    }
}
