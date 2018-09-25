namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Indicates a cash drawer shift's current state.
    /// </summary>
    public enum CashDrawerShiftState
    {
        /// <summary>
        /// The shift has been started by an authorized employee, but not yet ended.
        /// </summary>
        Open = 0,

        /// <summary>
        /// The shift has been ended by an authorized employee.
        /// </summary>
        Ended,

        /// <summary>
        /// The shift has been closed by an authorized employee, meaning they have manually counted and entered the final amount in the cash drawer.
        /// </summary>
        Closed,
    }
}
