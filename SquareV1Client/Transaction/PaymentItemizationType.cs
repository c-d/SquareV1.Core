namespace MeyerCorp.Square.V1.Transaction
{
    /// <summary>
    /// The type of purchase that a payment itemization represents.
    /// </summary>
    public enum PaymentItemizationType
    {
        /// <summary>
        /// The itemization represents an item variation from the merchant's item library.
        /// </summary>
        Item = 0,

        /// <summary>
        /// The itemization represents a monetary amount that is not associated with an item variation.
        /// </summary>
        CustomAmount,

        /// <summary>
        /// The itemization represents the activation of a Square gift card.
        /// </summary>
        GiftCardActivation,

        /// <summary>
        /// The itemization represents adding funds to a Square gift card.
        /// </summary>
        GiftCardReload,

        /// <summary>
        /// The itemization represents an unknown action performed on a Square gift card.
        /// </summary>
        GiftCardUnkown,

        /// <summary>
        /// The itemization represents an entity that doesn't match any other value.
        /// </summary>
        Other,
    }
}