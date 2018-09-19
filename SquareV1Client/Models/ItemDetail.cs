using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Models
{
    public class ItemDetail
    {
        [JsonProperty(PropertyName = "category_name")]
        public string CategoryName { get; set; }

        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        [JsonProperty(PropertyName = "item_id")]
        public string ItemId { get; set; }

        [JsonProperty(PropertyName = "item_variation_id")]
        public string ItemVariationId { get; set; }
    }
}