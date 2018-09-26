namespace MeyerCorp.Square.V1.Item
{
    /// <summary>
    /// Indicates an item's type. 
    /// </summary>
    /// <remarks>
    /// Almost all items have the type NORMAL.
    /// You cannot set an item's type with the Connect API.
    /// </remarks>
    public enum ItemType
    {
        /// <summary>
        /// The item is a normal item in the merchant's item library.
        /// </summary>
        Normal,

        /// <summary>
        /// The item is a Square gift card sold by the merchant.
        /// </summary>
        GiftCard,

        /// <summary>
        /// The item has a type that doesn't match any other value.
        /// </summary>
        Other,
    }
}
