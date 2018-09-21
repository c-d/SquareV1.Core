namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Indicates whether a merchant account is a single-location account or a business account.
    /// </summary>
    public enum MerchantAccountType
    {
        /// <summary>
        /// The account is a business account.
        /// </summary>
        Business = 0,

        /// <summary>
        /// The account is a single-location account.
        /// </summary>
        Location,
    }
}