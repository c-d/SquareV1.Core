using Newtonsoft.Json;
using System.Collections.Generic;

namespace MeyerCorp.Square.V1.Models
{
    public class Item
    {
        /// <summary>
        /// The item's unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The item's name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The item's description, if any.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The item's type. This value is NORMAL for almost all items.
        /// </summary>
        public ItemType Type
        {
            get { return ItemTypeString.ToItemType(); }
            set { ItemTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "type")]
        protected string ItemTypeString { get; set; }


        /// <summary>
        /// The text of the item's display label in Square Point of Sale. This value is present only if an abbreviation other than the default has been set.
        /// </summary>
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// The color of the item's display label in Square Point of Sale, if not the default color.
        /// </summary>
        /// <remarks>
        /// The default color is 9da2a6.
        /// </remarks>
        [JsonProperty(PropertyName = "color")]
        public ItemColorType Color { get; set; }

        /// <summary>
        /// Indicates whether the item is viewable in the merchant's online store (PUBLIC) or PRIVATE.
        /// </summary>
        [JsonProperty(PropertyName = "visibility")]
        public ItemVisibilityType ItemVisibility { get; set; }

        /// <summary>
        /// If true, the item is available for purchase from the merchant's online store.
        /// </summary>
        [JsonProperty(PropertyName = "available_online")]
        public bool IsAvailableOnline { get; set; }

        /// <summary>
        /// The item's master image, if any.
        /// </summary>
        [JsonProperty(PropertyName = "master_image")]
        public ItemImage ItemImage { get; set; }

        /// <summary>
        /// The category the item belongs to, if any.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public Category Category { get; set; }

        /// <summary>
        /// The item's variations.
        /// </summary>
        [JsonProperty(PropertyName = "variations")]
        public IEnumerable<ItemVariation> ItemVariations { get; set; }

        /// <summary>
        /// The modifier lists that apply to the item, if any.
        /// </summary>
        [JsonProperty(PropertyName = "modifier_lists")]
        public IEnumerable<ModifierList> ModifierLists { get; set; }

        /// <summary>
        /// The fees that apply to the item, if any.
        /// </summary>
        [JsonProperty(PropertyName = "fees")]
        public IEnumerable<Fee> Fees { get; set; }

        /// <summary>
        /// Deprecated.This field is not use
        /// </summary>
        [JsonProperty(PropertyName = "taxable")]
        public bool IsTaxable { get; set; }
    }
}