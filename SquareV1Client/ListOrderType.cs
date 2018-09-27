namespace MeyerCorp.Square.V1
{
    /// <summary>
    /// The chronological order in which results from a request are returned.
    /// </summary>
    public enum ListOrderType
    {
        /// <summary>
        /// Results are returned in standard chronological order (oldest first).
        /// </summary>
        /// <remarks>This is the default behavior for all List endpoints.</remarks>
        Ascending = 0,

        /// <summary>
        /// Results are returned in reverse-chronological order (newest first).
        /// </summary>
        Descending,
    }
}