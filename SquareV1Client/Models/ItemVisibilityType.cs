namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Indicates whether an item is viewable from a merchant's online store. 
    /// </summary>
    /// <remarks>
    /// This does not indicate whether the item is available for purchase in the online store.
    /// </remarks>
    public enum ItemVisibilityType
    {
        /// <summary>
        /// The item is viewable from the online store.
        /// </summary>
        Public,

        /// <summary>
        /// The item is not viewable from the online store.
        /// </summary>
        Private,
    }
}