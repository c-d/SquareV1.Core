namespace MeyerCorp.Square.V1.Business
{
    /// <summary>
    /// Permissions that can be granted to an employee role. If a role has been granted a particular permission, all employees with that role have that permission.
    /// </summary>
    public  enum EmployeeRolePermissionType
    {
        /// <summary>
        /// Allows employees to access the merchant's sales history in Square Point of Sale.
        /// </summary>
        RegisterAccessSalesHistory = 0,

        /// <summary>
        /// Allows employees to apply restricted discounts to a sale in Square Point of Sale.
        /// </summary>
        RegisterApplyRestrictedDiscounts,

        /// <summary>
        /// Allows employees to change the merchant's Square Point of Sale settings (such as enabling or disabling tipping).
        /// </summary>
        RegisterChangeSettings,

        /// <summary>
        /// Allows employees to edit the merchant's item library in Square Point of Sale. The item library includes all item-related entities, such as discounts and fees.
        /// </summary>
        RegisterEditItem,

        /// <summary>
        /// Allows employees to issue refunds for payments.
        /// </summary>
        RegisterIssueRefunds,

        /// <summary>
        /// Allows employees to open the cash drawer in circumstances other than during a cash transaction.
        /// </summary>
        RegisterOpenCashDrawerOutsideSale,

        /// <summary>
        /// Allows employees to view sales summary reports in Square Point of Sale.
        /// </summary>
        RegisterViewSummaryReports,
    }
}