using System;

namespace MeyerCorp.Square.V1.Webhooks
{
    /// <summary>
    /// Helper methods which make conversion of enum to and from string values required for HTTP/JSON more convenient.
    /// </summary>
    public static class EnumExtensions
    {
        public static string EnumToString(this WebhookEventType type)
        {
            switch (type)
            {
                case WebhookEventType.InventoryUpdated: return "INVENTORY_UPDATED";
                case WebhookEventType.PaymentUpdated: return "PAYMENT_UPDATED";
                case WebhookEventType.TimecardUpdated: return "TIMECARD_UPDATED";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static WebhookEventType ToWebhookEventType(this string value)
        {
            switch (value)
            {
                case "INVENTORY_UPDATED": return WebhookEventType.InventoryUpdated;
                case "PAYMENT_UPDATED": return WebhookEventType.PaymentUpdated;
                case "TIMECARD_UPDATED": return WebhookEventType.TimecardUpdated;
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}