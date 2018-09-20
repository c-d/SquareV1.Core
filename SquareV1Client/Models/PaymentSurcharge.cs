using Newtonsoft.Json;
using System.Collections.Generic;

namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Represents a surcharge applied to a payment.
    /// </summary>
    public class PaymentSurcharge
    {
        /// <summary>
        /// The name of the surcharge.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// "The amount of money applied to the order as a result of the surcharge."
        /// </summary>
        [JsonProperty(PropertyName = "applied_money")]
        public Money AppliedMoney { get; set; }

        /// <summary>
        /// The amount of the surcharge as a percentage. The percentage is provided as a string representing the decimal equivalent of the percentage.For example, "0.7" corresponds to a 7% surcharge.Exactly one of rate or amount_money should be set.
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public string Rate { get; set; }

        /// <summary>
        /// "The amount of the surcharge as a Money object. Exactly one of rate or amount_money should be set."
        /// </summary>
        [JsonProperty(PropertyName = "amount_money")]
        public Money AmountMoney { get; set; }

        /// <summary>
        /// Indicates the source of the surcharge (CUSTOM or AUTO-GRATUITY). For example, if it was applied as an automatic gratuity for a large group.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public SurchargeType Type { get; set; }

        /// <summary>
        /// Indicates whether the surcharge is taxable.
        /// </summary>
        [JsonProperty(PropertyName = "taxable")]
        public bool IsTaxable { get; set; }

        /// <summary>
        /// The list of taxes that should be applied to the surcharge.
        /// </summary>
        [JsonProperty(PropertyName = "taxes")]
        public IEnumerable<PaymentTax> Taxes { get; set; }

        /// <summary>
        /// A Square-issued unique identifier associated with the surcharge.
        /// </summary>
        [JsonProperty(PropertyName = "surcharge_id")]
        public string SurchargeId { get; set; }
    }
}