namespace MeyerCorp.Square.V1.Transaction
{
    /// <summary>
    /// A bank account's type (savings, checking, and so on).
    /// </summary>
    public enum BankAccountType
    {
        /// <summary>
        /// A business checking account.
        /// </summary>
        BusinessChecking,
        /// <summary>
        /// A checking account.
        /// </summary>
        Checking,
        /// <summary>
        /// An investment account.
        /// </summary>
        Investment,
        /// <summary>
        /// A loan account.
        /// </summary>
        Loan,
        /// <summary>
        /// A savings account.
        /// </summary>
        Savings,
        /// <summary>
        /// A type of bank account that does not match any other value.
        /// </summary>
        Other
    }
}
