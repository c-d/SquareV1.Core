namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// The type of tender used in a payment.
    /// </summary>
    public enum TenderType
    {
        /// <summary>
        /// A credit card processed with Square.
        /// </summary>
        CreditCard = 0,

        /// <summary>
        /// Cash.
        /// </summary>
        Cash,

        /// <summary>
        /// A credit card processed with a card processor other than Square.
        /// </summary>
        /// <remarks>
        /// This value applies only to merchants in countries where Square does not yet provide card processing.
        /// </remarks>
        ThirdPartyCard,

        /// <summary>
        /// No sale.
        /// </summary>
        NoSale,

        /// <summary>
        /// A Square Wallet payment.
        /// </summary>
        SquareWallet,

        /// <summary>
        /// A Square gift card.
        /// </summary>
        SquareGiftCard,

        /// <summary>
        /// An unknown tender type.
        /// </summary>
        Unknown,

        /// <summary>
        /// A form of tender that does not match any other value.
        /// </summary>
        Other,
    }
}