using MeyerCorp.Square.V1.Models;
using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Item
{
    public class ItemVariation
    {
        /// <summary>
        /// The item variation's unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The item variation's name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the variation's associated item.
        /// </summary>
        [JsonProperty(PropertyName = "item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// Indicates the variation's list position when displayed in Square Point of Sale and the merchant dashboard. If more than one variation for the same item has the same  ordinal value, those variations are displayed in alphabetical order.
        /// </summary>
        /// <remarks>
        /// An item's variation with the lowest ordinal value is displayed first.
        /// </remarks>
        [JsonProperty(PropertyName = "ordinal")]
        public long Ordinal { get; set; }

        /// <summary>
        /// Indicates whether the item variation's price is fixed or determined at the time of sale.
        /// </summary>
        public ItemVariationPricingType PricingType
        {
            get { return ItemVariationPricingTypeString.ToItemVariationPricingType(); }
            set { ItemVariationPricingTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "pricing_type")]
        protected string ItemVariationPricingTypeString { get; set; }
        
        /// <summary>
        /// The item variation's price, if any.
        /// </summary>
        [JsonProperty(PropertyName = "price_money")]
        public Money Price { get; set; }

        /// <summary>
        /// The item variation's SKU, if any.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// If true, inventory tracking is active for the variation.
        /// </summary>
        [JsonProperty(PropertyName = "track_inventory")]
        public bool IsTrackInventoryActive { get; set; }

        /// <summary>
        /// Indicates whether the item variation displays an alert when its inventory quantity is less than or equal to its inventory_alert_threshold.
        /// </summary>
        [JsonProperty(PropertyName = "inventory_alert_type")]
        public InventoryAlertType InventoryAlertType
        {
            get { return InventoryAlertTypeString.ToInventoryAlertType(); }
            set { InventoryAlertTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "business_type")]
        protected string InventoryAlertTypeString { get; set; }
        
        /// <summary>
        /// If the inventory quantity for the variation is less than or equal to this value and  inventory_alert_type is LOW_QUANTITY, the variation displays an alert in the merchant dashboard.
        /// </summary>
        /// <remarks>
        /// This value is always an integer.
        /// </remarks>
        [JsonProperty(PropertyName = "inventory_alert_threshold")]
        public long InventoryAlertThreshold { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the variation.Cannot exceed 255 characters.    }
        /// </summary>
        [JsonProperty(PropertyName = "user_data")]
        public string UserData { get; set; }
    }
}
