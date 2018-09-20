using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Represents a modifier option applied to an itemization in a payment.
    /// </summary>
    public class PaymentModifier
    {
        /// <summary>
        /// The modifier option's name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The amount of money that this modifier option adds to the payment.
        /// </summary>
        [JsonProperty(PropertyName = "applied_money")]
        public Money AppliedMoney { get; set; }

        /// <summary>
        /// The ID of the applied modifier option, if available. Modifier options applied in older versions of Square Point of Sale might not have an ID.
        /// </summary>
        [JsonProperty(PropertyName = "modifier_option_id")]
        public string ModifierOptionId { get; set; }
    }
}