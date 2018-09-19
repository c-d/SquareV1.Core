using Newtonsoft.Json;
using System;

namespace Meyer.Square.V1.Models
{
    public class Refund
    {
        [JsonProperty(PropertyName = "type")]
        public RefundType Type { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime Created { get; set; }

        [JsonProperty(PropertyName = "processed_at")]
        public DateTime Processed { get; set; }

        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        [JsonProperty(PropertyName = "refunded_money")]
        public Money RefundedMoney { get; set; }

        [JsonProperty(PropertyName = "payment_id")]
        public string PaymentId { get; set; }

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

        [JsonProperty(PropertyName = "is_exchange")]
        public bool IsExchange { get; set; }
    }
}