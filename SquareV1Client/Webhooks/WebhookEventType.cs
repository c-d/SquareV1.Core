namespace MeyerCorp.Square.V1.Webhooks
{
    /// <summary>
    /// The type of an event that sends a notification to an application.
    /// </summary>
    public enum WebhookEventType
    {
        /// <summary>
        /// A payment was updated or created.
        /// </summary>
        PaymentUpdated,

        /// <summary>
        /// At least one item variation's inventory count was updated.
        /// </summary>
        InventoryUpdated,

        /// <summary>
        /// An employee timecard was updated or created.
        /// </summary>
        TimecardUpdated,
    }
}
