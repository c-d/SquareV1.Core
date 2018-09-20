using Newtonsoft.Json;
using System.Collections.Generic;

namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Represents an item, custom monetary amount, or other entity purchased as part of a payment.
    /// </summary>
    public class PaymentItemization
    {
        /// <summary>
        /// The item's name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The quantity of the item purchased. This can be a decimal value.
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Notes entered by the merchant about the item at the time of payment, if any.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        /// <summary>
        /// The name of the item variation purchased, if any.
        /// </summary>
        [JsonProperty(PropertyName = "item_variation_name")]
        public string ItemVariationName { get; set; }

        /// <summary>
        /// Details of the item, including its unique identifier and the identifier of the item variation purchased.
        /// </summary>
        [JsonProperty(PropertyName = "item_detail")]
        public PaymentItemDetail ItemDetail { get; set; }

        /// <summary>
        /// The type of purchase that the itemization represents, such as an ITEM or  CUSTOM_AMOUNT.
        /// </summary>
        [JsonProperty(PropertyName = "itemization_type")]
        public PaymentItemizationType Type { get; set; }

        /// <summary>
        /// The total cost of the item, including all taxes and discounts.
        /// </summary>
        [JsonProperty(PropertyName = "total_money")]
        public Money TotalMoney { get; set; }

        /// <summary>
        /// The cost of a single unit of this item.
        /// </summary>
        [JsonProperty(PropertyName = "single_quantity_money")]
        public Money SingleQuantityMoney { get; set; }

        /// <summary>
        /// The total cost of the itemization and its modifiers, not including taxes or discounts.
        /// </summary>
        [JsonProperty(PropertyName = "gross_sales_money")]
        public Money GrossSalesMoney { get; set; }

        /// <summary>
        /// The total of all discounts applied to the itemization. This value is always negative or zero.
        /// </summary>
        [JsonProperty(PropertyName = "discount_money")]
        public Money DiscountMoney { get; set; }

        /// <summary>
        /// The sum of gross_sales_money and discount_money.
        /// </summary>
        [JsonProperty(PropertyName = "net_sales_money")]
        public Money NetSalesMoney { get; set; }

        /// <summary>
        /// All taxes applied to this itemization.
        /// </summary>
        [JsonProperty(PropertyName = "taxes")]
        public IEnumerable<PaymentTax> Taxes { get; set; }

        /// <summary>
        /// All discounts applied to this itemization.
        /// </summary>
        [JsonProperty(PropertyName = "discounts")]
        public IEnumerable<Discount> Discounts { get; set; }

        /// <summary>
        /// All modifier options applied to this itemization.
        /// </summary>
        [JsonProperty(PropertyName = "modifiers")]
        public IEnumerable<PaymentModifier> Modifiers { get; set; }
    }
}