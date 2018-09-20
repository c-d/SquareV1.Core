using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Represents a discount applied to an itemization in a payment.
    /// </summary>
    public class PaymentDiscount
    {
        /// <summary>
        /// The discount's name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The amount of money that this discount adds to the payment (note that this value is always negative or zero).
        /// </summary>
        [JsonProperty(PropertyName = "applied_money")]
        public Money AppliedMoney { get; set; }

        /// <summary>
        /// The ID of the applied discount, if available.Discounts applied in older versions of Square Point of Sale might not have an ID. }
        /// </summary>
        [JsonProperty(PropertyName = "discount_id")]
        public string DiscountId { get; set; }
    }
}
