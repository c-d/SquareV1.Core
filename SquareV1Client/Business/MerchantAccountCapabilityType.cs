namespace MeyerCorp.Square.V1.Business
{
    /// <summary>
    /// Capabilities that a merchant's associated Square account might have. You can get a merchant's account capabilities with the Retrieve Mechant endpoint.
    /// </summary>
    public enum MerchantAccountCapabilityType
    {
        /// <summary>
        /// The merchant can process credit cards with Square.
        /// </summary>
        CreditCardProcessing = 0,

        /// <summary>
        /// Applies to multi-location accounts. The merchant can add employees and manage employee roles and permissions.
        /// </summary>
        EmployeeManagement,

        /// <summary>
        /// Applies to multi-location accounts.The merchant can use timecards to track when their employees clock in and out.
        /// </summary>
        TimecardManagement,
    }
}
