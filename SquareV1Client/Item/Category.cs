using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Item
{
    /// <summary>
    /// Represents an item category.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// The category's unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The category's name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
