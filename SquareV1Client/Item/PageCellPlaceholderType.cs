namespace MeyerCorp.Square.V1.Item
{
    /// <summary>
    /// Indicates the behavior of a page cell with the special PLACEHOLDER object type. See Favorites Pages for more information.
    /// </summary>
    public enum PageCellPlaceholderType
    {
        /// <summary>
        /// The cell presents a list of all the merchant's items. The cell is labeled All Items.
        /// </summary>
        AllItems,

        /// <summary>
        /// The cell presents a list of all the merchant's discounts. The cell is labeled Discounts.
        /// </summary>
        DiscountsCategory,

        /// <summary>
        /// The cell presents a view for selecting customer rewards. The cell is labeled Redeem Rewards.
        /// </summary>
        /// <remarks>
        /// Learn more about Square Point of Sale rewards.
        /// </remarks>
        RewardsFinder
    }
}
