namespace MeyerCorp.Square.V1.Item
{
    /// <summary>
    /// Indicates whether the item variation generates an alert when its inventory quantity goes below its inventory_alert_threshold.
    /// </summary>
    public enum InventoryAlertType
    {
        /// <summary>
        /// The variation generates an alert when its quantity is low.
        /// </summary>
        LowQuantity,

        /// <summary>
        /// The variation does not display an alert.
        /// </summary>
        None
    }
}
