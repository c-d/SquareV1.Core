using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Represents inventory information for one of a merchant's item variations.
    /// </summary>
    public class InventoryEntry
    {
        /// <summary>
        /// The variation that the entry corresponds to.
        /// </summary>
        [JsonProperty(PropertyName = "variation_id")]
        public string VariationId{ get; set; }

        /// <summary>
        /// The current available quantity of the item variation.
        /// </summary>
        [JsonProperty(PropertyName = "quantity_on_hand")]
        public long QuantityOnHand{ get; set; }
    }
}
