using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Represents additional details for a single-location account as specified by its parent business.
    /// </summary>
    public class MerchantLocationDetails
    {
        /// <summary>
        /// The nickname assigned to the single-location account by the parent business. This value appears in the parent business' multi-location dashboard.
        /// </summary>
        [JsonProperty(PropertyName = "nickname")]
        public string Nickname { get; set; }
    }
}