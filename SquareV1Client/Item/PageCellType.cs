namespace MeyerCorp.Square.V1.Item
{
    /// <summary>
    /// The type of entity represented by a page cell.
    /// </summary>
    public enum PageCellType
    {
        /// <summary>
        /// An item.
        /// </summary>
        Item,

        /// <summary>
        /// A discount.
        /// </summary>
        Discount,

        /// <summary>
        /// A category.
        /// </summary>
        Category,

        /// <summary>
        /// The cell is one of the special types described in PageCell.PlaceholderType.
        /// </summary>
        Placeholder
    }
}
