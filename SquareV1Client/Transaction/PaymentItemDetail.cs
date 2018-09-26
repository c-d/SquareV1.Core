using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Transaction
{
    /// <summary>
    /// Represents details of an item purchased in a payment.
    /// </summary>
    public class PaymentItemDetail
    {
        /// <summary>
        /// The name of the item's merchant-defined category, if any.
        /// </summary>
        [JsonProperty(PropertyName = "category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// The item's merchant-defined SKU, if any.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// The unique ID of the item purchased, if any.
        /// </summary>
        [JsonProperty(PropertyName = "item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// The unique ID of the item variation purchased, if any.
        /// </summary>
        [JsonProperty(PropertyName = "item_variation_id")]
        public string ItemVariationId { get; set; }
    }
}