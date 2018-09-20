namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Indicates the source of the surcharge. For example, if it was applied as an automatic gratuity for a large group.
    /// </summary>
    public enum SurchargeType
    {
        /// <summary>
        /// Placeholder for future functionality.
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// A non-negotiable percentage-based surcharge automatically applied to the purchase total.
        /// </summary>
        AutoGratuity,
        /// <summary>
        /// An ad hoc surcharge manually applied to the purchase total as a percentage or flat amount.
        /// </summary>
        Custom,
    }
}
