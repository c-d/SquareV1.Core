using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MeyerCorp.Square.V1.Transaction
{
    public class Payment
    {
        /// <summary>
        /// The payment's unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The unique identifier of the merchant that took the payment.
        /// </summary>
        [JsonProperty(PropertyName = "merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// The time when the payment was created, in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "created_at")]
        public DateTime Created { get; set; }

        /// <summary>
        ///The unique identifier of the Square account that took the payment.
        /// </summary>
        /// <remarks>
        /// This value can differ from merchant_id if the merchant has mobile staff.
        /// </remarks>
        [JsonProperty(PropertyName = "created_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// The device that took the payment.
        /// </summary>
        [JsonProperty(PropertyName = "device")]
        public Device Device { get; set; }

        /// <summary>
        /// The URL of the payment's detail page in the merchant dashboard. The merchant must be signed in to the merchant dashboard to view this page.
        /// </summary>
        [JsonProperty(PropertyName = "payment_url")]
        public string PaymentUrl { get; set; }

        /// <summary>
        /// The URL of the receipt for the payment.
        /// </summary>
        /// <remarks>
        /// Note that for split tender payments, this URL corresponds to the receipt for the first tender listed in the payment's  tender field. Each Tender object has its own receipt_url field you can use to get the other receipts associated with a split tender payment.
        /// </remarks>
        [JsonProperty(PropertyName = "receipt_url")]
        public string ReceiptUrl { get; set; }

        /// <summary>
        /// The sum of all inclusive taxes associated with the payment.
        /// </summary>
        [JsonProperty(PropertyName = "inclusive_tax_money")]
        public Money InclusiveTaxMoney { get; set; }

        /// <summary>
        /// The sum of all additive taxes associated with the payment.
        /// </summary>
        [JsonProperty(PropertyName = "additive_tax_money")]
        public Money AdditiveTaxMoney { get; set; }

        /// <summary>
        /// The total of all taxes applied to the payment.
        /// </summary>
        /// <remarks>
        /// This is always the sum of inclusive_tax_money and additive_tax_money.
        /// </remarks>
        [JsonProperty(PropertyName = "tax_money")]
        public Money TaxMoney { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tip_money")]
        public Money TipMoney { get; set; }

        /// <summary>
        /// The total of all discounts applied to the payment.
        /// </summary>
        /// <remarks>
        /// This value is always 0 or negative.
        /// </remarks>
        [JsonProperty(PropertyName = "discount_money")]
        public Money DiscountMoney { get; set; }

        /// <summary>
        /// The total amount of money collected from the buyer for the payment.
        /// </summary>
        /// <remarks>
        /// This value is always 0 or negative.
        /// </remarks>
        [JsonProperty(PropertyName = "total_collected_money")]
        public Money TotalCollectedMoney { get; set; }

        /// <summary>
        /// The total of all processing fees collected by Square for the payment.
        /// </summary>
        /// <remarks>
        /// This value is always 0 or negative.
        /// </remarks>
        [JsonProperty(PropertyName = "processing_fee_money")]
        public Money ProcessingFeeMoney { get; set; }

        /// <summary>
        /// The amount to be deposited into the merchant's bank account for the payment.
        /// </summary>
        /// <remarks>
        /// This is always the sum of total_collected_money and processing_fee_money (note that processing_fee_money is always negative or 0).
        /// </remarks>
        [JsonProperty(PropertyName = "net_total_money")]
        public Money NetTotalMoney { get; set; }

        /// <summary>
        /// The total of all refunds applied to the payment.
        /// </summary>
        [JsonProperty(PropertyName = "refunded_money")]
        public Money RefundedMoney { get; set; }

        /// <summary>
        /// The total of all sales, including any applicable taxes, rounded to the smallest legal unit of currency (e.g., the nearest penny in USD, the nearest nickel in CAD)
        /// </summary>
        [JsonProperty(PropertyName = "swedish_rounding_money")]
        public Money SwedishRoundingMoney { get; set; }

        /// <summary>
        /// The total cost of the itemization and its modifiers, not including taxes or discounts.
        /// </summary>
        [JsonProperty(PropertyName = "gross_sales_money")]
        public Money GroseSalesMoney { get; set; }

        /// <summary>
        /// The sum of gross_sales_money and discount_money.
        /// </summary>
        [JsonProperty(PropertyName = "net_sales_money")]
        public Money NetSalesMoney { get; set; }

        /// <summary>
        /// The total of all surcharges applied to the payment.
        /// </summary>
        [JsonProperty(PropertyName = "surcharge_money")]
        public Money SurchargeMoney { get; set; }

        /// <summary>
        /// A list of all surcharges associated with the payment.
        /// </summary>
        [JsonProperty(PropertyName = "surcharges")]
        public IEnumerable<PaymentSurcharge> Surcharges { get; set; }

        /// <summary>
        /// All of the inclusive taxes associated with the payment.
        /// </summary>
        [JsonProperty(PropertyName = "inclusive_tax")]
        public IEnumerable<PaymentTax> InclusiveTax { get; set; }

        /// <summary>
        /// All of the additive taxes associated with the payment.
        /// </summary>
        [JsonProperty(PropertyName = "additive_tax")]
        public IEnumerable<PaymentTax> AdditiveTax { get; set; }

        /// <summary>
        /// The form(s) of tender provided by the buyer for the payment.
        /// </summary>
        [JsonProperty(PropertyName = "tender")]
        public IEnumerable<Tender> Tender { get; set; }

        /// <summary>
        /// All of the refunds applied to the payment.
        /// </summary>
        /// <remarks>
        /// Note that the value of all refunds on a payment can exceed the value of all tenders, because a merchant can choose to refund money to a tender after already accepting some good for exchange.
        /// </remarks>
        [JsonProperty(PropertyName = "refunds")]
        public IEnumerable<Refund> Refunds { get; set; }

        /// <summary>
        /// The items purchased in the payment.
        /// </summary>
        [JsonProperty(PropertyName = "itemizations")]
        public IEnumerable<PaymentItemization> Itemizations { get; set; }
    }
}
