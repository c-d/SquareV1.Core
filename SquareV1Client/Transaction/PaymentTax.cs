using MeyerCorp.Square.V1.Models;
using Newtonsoft.Json;
using System;

namespace MeyerCorp.Square.V1.Transaction
{
    /// <summary>
    /// Represents a single tax applied to a payment.
    /// </summary>
    public class PaymentTax
    {
        /// <summary>
        /// The merchant-defined name of the tax.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The rate of the tax, as a string representation of a decimal number. A value of  0.07 corresponds to a rate of 7%.
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public decimal Rate { get; set; }

        /// <summary>
        /// Whether the tax is an ADDITIVE tax or an INCLUSIVE tax.
        /// </summary>
        public FeeInclusionType InclusionType
        {
            get
            {
                switch (InclusionTypeString)
                {
                    case "ADDITIVE": return FeeInclusionType.Additive;
                    default: throw new InvalidOperationException("Inclusion Type String value is not supported.");
                }
            }
            set
            {
                switch (value)
                {
                    case FeeInclusionType.Additive: InclusionTypeString = "ADDITIVE"; break;
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }

        [JsonProperty(PropertyName = "inclusion_type")]
        protected string InclusionTypeString { get; set; }

        /// <summary>
        /// The amount of money that this tax adds to the payment.
        /// </summary>
        [JsonProperty(PropertyName = "applied_money")]
        public Money AppliedMoney { get; set; }

        /// <summary>
        /// The ID of the tax, if available. Taxes applied in older versions of Square Point of Sale might not have an ID.
        /// </summary>
        [JsonProperty(PropertyName = "fee_id")]
        public string FeeId { get; set; }
    }
}