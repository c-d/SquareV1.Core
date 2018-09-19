using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MeyerCorp.Square.V1.Models
{
    public class Payment
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "merchant_id")]
        public string MerchantId { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime Created { get; set; }

        [JsonProperty(PropertyName = "payment_url")]
        public string PaymentUrl { get; set; }

        [JsonProperty(PropertyName = "receipt_url")]
        public string ReceiptUrl { get; set; }

        [JsonProperty(PropertyName = "inclusive_tax_money")]
        public Money InclusiveTaxMoney { get; set; }

        [JsonProperty(PropertyName = "additive_tax_money")]
        public Money AdditiveTaxMoney { get; set; }

        [JsonProperty(PropertyName = "tax_money")]
        public Money TaxMoney { get; set; }

        [JsonProperty(PropertyName = "tip_money")]
        public Money TipMoney { get; set; }

        [JsonProperty(PropertyName = "discount_money")]
        public Money DiscountMoney { get; set; }

        [JsonProperty(PropertyName = "total_collected_money")]
        public Money TotalCollectedMoney { get; set; }

        [JsonProperty(PropertyName = "processing_fee_money")]
        public Money ProcessingFeeMoney { get; set; }

        [JsonProperty(PropertyName = "net_total_money")]
        public Money NetTotalMoney { get; set; }

        [JsonProperty(PropertyName = "refunded_money")]
        public Money RefundedMoney { get; set; }

        [JsonProperty(PropertyName = "swedish_rounding_money")]
        public Money SwedishRoundingMoney { get; set; }

        [JsonProperty(PropertyName = "gross_sales_money")]
        public Money GroseSalesMoney { get; set; }

        [JsonProperty(PropertyName = "net_sales_money")]
        public Money NetSalesMoney { get; set; }

        [JsonProperty(PropertyName = "surcharge_money")]
        public Money SurchargeMoney { get; set; }

        [JsonProperty(PropertyName = "surcharges")]
        public IEnumerable<Surcharge> Surcharges { get; set; }

        [JsonProperty(PropertyName = "inclusive_tax")]
        public IEnumerable<Tax> InclusiveTax { get; set; }

        [JsonProperty(PropertyName = "additive_tax")]
        public IEnumerable<Tax> AdditiveTax { get; set; }

        [JsonProperty(PropertyName = "tender")]
        public IEnumerable<Tender> Tender { get; set; }

        [JsonProperty(PropertyName = "refunds")]
        public IEnumerable<Refund> Refunds { get; set; }

        [JsonProperty(PropertyName = "itemizations")]
        public IEnumerable<Itemization> Itemizations { get; set; }
    }
}
