using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Represents an image of an item.
    /// </summary>
    public class ItemImage
    {
        /// <summary>
        /// The image's unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The image's publicly accessible URL.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
