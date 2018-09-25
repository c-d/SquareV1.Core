namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Indicates whether an item variation's price is fixed or entered at the time of sale.
    /// </summary>
    public enum ItemVariationPricingType
    {
        /// <summary>
        /// The item variation's price is fixed.
        /// </summary>
        FixedPricing,

        /// <summary>
        /// The item variation's price is entered at the time of sale.
        /// </summary>
        VariablePricing
    }
}
