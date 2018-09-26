using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Business
{
    /// <summary>
    /// Represents geographic coordinates.
    /// </summary>
    public class Coordinates
    {
        /// <summary>
        /// The latitude coordinate, in degrees.
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public decimal Latitude { get; set; }

        /// <summary>
        /// The longitude coordinate, in degrees.
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public decimal Longitude { get; set; }
    }
}