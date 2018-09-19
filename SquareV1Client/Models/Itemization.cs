using Newtonsoft.Json;
using System.Collections.Generic;

namespace MeyerCorp.Square.V1.Models
{
    public class Itemization
    {
        [JsonProperty(PropertyName = "name")]

        public string Name { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public decimal Quantity { get; set; }

        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        [JsonProperty(PropertyName = "item_variation_name")]
        public string ItemVariationName { get; set; }

        [JsonProperty(PropertyName = "item_detail")]
        public ItemDetail ItemDetail { get; set; }

        [JsonProperty(PropertyName = "itemization_type")]
        public ItemizationType Type { get; set; }

        [JsonProperty(PropertyName = "total_money")]
        public Money TotalMoney { get; set; }

        [JsonProperty(PropertyName = "single_quantity_money")]
        public Money SingleQuantityMoney { get; set; }

        [JsonProperty(PropertyName = "gross_sales_money")]
        public Money GrossSalesMoney { get; set; }

        [JsonProperty(PropertyName = "discount_money")]
        public Money DiscountMoney { get; set; }

        [JsonProperty(PropertyName = "net_sales_money")]
        public Money NetSalesMoney { get; set; }

        [JsonProperty(PropertyName = "taxes")]
        public IEnumerable<Tax> Taxes { get; set; }

        [JsonProperty(PropertyName = "discounts")]
        public IEnumerable<Discount> Discounts { get; set; }

        [JsonProperty(PropertyName = "modifiers")]
        public IEnumerable<Modifier> Modifiers { get; set; }
    }
}