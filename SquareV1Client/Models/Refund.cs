using Newtonsoft.Json;
using System;

namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Represents a refund initiated by a Square merchant.
    /// </summary>
    public class Refund
    {
        /// <summary>
        /// The type of refund (FULL or PARTIAL).
        /// </summary>
        public RefundType Type
        {
            get { return TypeString.ToRefundType(); }
            set { TypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "type")]
        public string TypeString { get; set; }

        /// <summary>
        /// The time when the merchant initiated the refund for Square to process, in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "created_at")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The time when Square processed the refund on behalf of the merchant, in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "processed_at")]
        public DateTime Processed { get; set; }

        /// <summary>
        /// The merchant-specified reason for the refund.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The amount of money refunded. This amount is always negative.
        /// </summary>
        [JsonProperty(PropertyName = "refunded_money")]
        public Money RefundedMoney { get; set; }

        /// <summary>
        /// The Square-issued ID of the payment the refund is applied to.
        /// </summary>
        /// <remarks>
        /// For refunds to split-tender payments, payment_id instead is the tender's ID.
        /// For exchange refunds (is_exchange == true), payment_id is the payment's ID, regardless of whether the payment has other tenders.
        /// </remarks>
        [JsonProperty(PropertyName = "payment_id")]
        public string PaymentId { get; set; }

        /// <summary>
        /// The unique identifier of the merchant that took the payment.
        /// </summary>
        [JsonProperty(PropertyName = "merchant_id")]
        public string MerchantId { get; set; }

        [JsonProperty(PropertyName = "refunded_processing_fee_money")]
        public Money RefundedProcessingFeeMoney { get; set; }

        [JsonProperty(PropertyName = "refunded_inclusive_tax")]
        public object RefundedInclusiveTax { get; set; }

        [JsonProperty(PropertyName = "refunded_additive_tax")]
        public object RefundedAdditiveTax { get; set; }

        [JsonProperty(PropertyName = "refunded_surcharges")]
        public object RefundedSurcharges { get; set; }

        /// <summary>
        /// Indicates whether or not the refund is associated with an exchange. If true, this refund reflects the value of goods returned in the exchange, rather than actual money refunded.
        /// </summary>
        [JsonProperty(PropertyName = "is_exchange")]
        public bool IsExchange { get; set; }
    }
}