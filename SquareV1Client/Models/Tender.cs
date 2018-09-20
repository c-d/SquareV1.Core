using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Represents a form and amount of tender provided for a payment. Multiple forms of tender can be provided for a single payment.
    /// </summary>
    public class Tender
    {
        /// <summary>
        /// The type of tender.
        /// </summary>
        public TenderType Type
        {
            get { return TypeString.ToTenderType(); }
            set { TypeString = value.EnumToString(); }
        }

        protected string TypeString { get; set; }

        /// <summary>
        /// A human-readable description of the tender.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The tender's unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The total amount of money provided in this form of tender.
        /// </summary>
        [JsonProperty(PropertyName = "total_money")]
        public Money TotalMoney { get; set; }

        /// <summary>
        /// The amount of total_money applied to the payment.
        /// </summary>
        [JsonProperty(PropertyName = "tendered_money")]
        public Money TenderedMoney { get; set; }

        /// <summary>
        /// The amount of total_money returned to the buyer as change.
        /// </summary>
        [JsonProperty(PropertyName = "change_back_money")]
        public Money ChargeBackMoney { get; set; }

        /// <summary>
        /// The brand of credit card provided.
        /// </summary>
        /// <remarks>
        /// Only present if the tender's type is  CREDIT_CARD.
        /// </remarks>
        public CardBrandType CardBrand
        {
            get { return CardBrandTypeString.ToCardBrandType(); }
            set { CardBrandTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "card_brand")]
        protected string CardBrandTypeString { get; set; }

        /// <summary>
        /// The last four digits of the provided credit card's account number.
        /// </summary>
        /// <remarks>
        /// Only present if the tender's type is  CREDIT_CARD.
        /// </remarks>
        [JsonProperty(PropertyName = "pan_suffix")]
        public string PanSuffix { get; set; }

        /// <summary>
        /// Notes entered by the merchant about the tender at the time of payment, if any. Typically only present for tender with the typeOTHER.
        /// </summary>
        [JsonProperty(PropertyName = "payment_note")]
        public string PaymentNote { get; set; }

        /// <summary>
        /// The method with which the tender was entered.
        /// </summary>
        public EntryMethodType EntryMethod
        {
            get { return EntryMethodTypeString.ToEntryMethodType(); }
            set { EntryMethodTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "entry_method")]
        protected string EntryMethodTypeString { get; set; }

        /// <summary>
        /// The total of all refunds applied to this tender. This amount is always negative or zero.
        /// </summary>
        [JsonProperty(PropertyName = "refunded_money")]
        public Money RefundedMoney { get; set; }

        /// <summary>
        /// The URL of the receipt for the tender.
        /// </summary>
        [JsonProperty(PropertyName = "receipt_url")]
        public string ReceiptUrl { get; set; }

        /// <summary>
        /// The ID of the employee that processed the tender.
        /// </summary>
        /// <remarks>
        /// This field is included only if the associated merchant had employee management features enabled at the time the tender was processed.
        /// </remarks>
        [JsonProperty(PropertyName = "employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// Indicates whether or not the tender is associated with an exchange. If so, this tender represents the value of goods returned in an exchange, rather than actual money paid. This value reduces the amount of any other tenders needed to pay for itemizations purchased in the exchange.
        /// </summary>
        [JsonProperty(PropertyName = "is_exchange")]
        public bool IsExchange { get; set; }
    }
}