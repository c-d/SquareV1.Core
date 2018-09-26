using Newtonsoft.Json;

namespace MeyerCorp.Square.V1
{
    /// <summary>
    /// Represents a device running Square Point of Sale.
    /// </summary>
    public class Device
    {
        /// <summary>
        /// The device's merchant-specified name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The device's Square-issued ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}