namespace Meyer.Square.V1
{
    /// <summary>
    /// Indicates whether date range results are returned in chronological or reverse-chronological order.
    /// </summary>
    /// <remarks>
    /// Regardless of order, <code>begin_time</code> is the earlier date and <code>end_time</code> is the later date.
    /// </remarks>
    public enum DateRangeOrderType
    {
        /// <summary>
        /// When <code>order</code> is ASC (chronological), <code>begin_time</code> is inclusive and <code>end_time</code> is exclusive. 
        /// </summary>
        /// <remarks>This is the default behavior for all List endpoints.</remarks>
        Ascending = 0,

        /// <summary>
        /// When <code>order</code> is DESC (reverse-chronological), <code>begin_time</code> is exclusive and <code>end_time</code> is inclusive.
        /// </summary>
        Descending,
    }
}