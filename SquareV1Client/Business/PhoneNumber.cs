using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Business
{
    /// <summary>
    /// Represents a phone number.
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// The phone number's international calling code. For US phone numbers, this value is  +1.
        /// </summary>
        [JsonProperty(PropertyName = "calling_code")]
        string CallingCode { get; set; }

        /// <summary>
        /// The phone number. 
        /// </summary>
        [JsonProperty(PropertyName = "number")]
        string Number { get; set; }
    }
}