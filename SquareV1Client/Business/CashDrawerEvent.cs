using Newtonsoft.Json;
using System;

namespace MeyerCorp.Square.V1.Business
{
    /// <summary>
    /// Represents an event (such as a payment or refund) that involved opening the cash drawer during a cash drawer shift.
    /// </summary>
    public class CashDrawerEvent
    {
        /// <summary>
        /// The event's unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the employee that created the event.
        /// </summary>
        [JsonProperty(PropertyName = "employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// The type of event that occurred, such as CASH_TENDER_PAYMENT or  CASH_TENDER_REFUND.
        /// </summary>
        public CashDrawerEventType EventType
        {
            get { return CashDrawerEventTypeString.ToCashDrawerEventType(); }
            set { CashDrawerEventTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "event_type")]
        protected string CashDrawerEventTypeString { get; set; }


        /// <summary>
        /// The amount of money that was added to or removed from the cash drawer because of the event. This value can be positive (for added money) or negative(for removed money).
        /// </summary>
        [JsonProperty(PropertyName = "event_money")]
        public Money EventMoney { get; set; }

        /// <summary>
        /// The time when the event occurred, in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "created_at")]
        public DateTime Created { get; set; }

        /// <summary>
        /// An optional description of the event, entered by the employee that created it.   }
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}