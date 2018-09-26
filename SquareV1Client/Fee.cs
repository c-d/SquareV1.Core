using Newtonsoft.Json;

namespace MeyerCorp.Square.V1
{
    /// <summary>
    /// Represents a tax or other fee that can be applied to a payment.
    /// </summary>
    public class Fee
    {
        /// <summary>
        /// The fee's unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        string Id { get; set; }

        /// <summary>
        /// The fee's name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        string Name { get; set; }

        /// <summary>
        /// The rate of the fee, as a string representation of a decimal number.A value of  0.07 corresponds to a rate of 7%.
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        string Rate { get; set; }

        /// <summary>
        /// Forthcoming.
        /// </summary>
        FeeCalculationPhaseType CalculationPhaseType
        {
            get { return CalculationPhaseTypeString.ToFeeCalculationPhaseType(); }
            set { CalculationPhaseTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "calculation_phase")]
        protected string CalculationPhaseTypeString { get; set; }

        /// <summary>
        /// The type of adjustment the fee applies to a payment.Currently, this value is  TAX for all fees.
        /// </summary>
        [JsonProperty(PropertyName = "adjustment_type")]
        FeeAdjustmentType AdjustmentType
        {
            get { return FeeAdjustmentTypeString.ToFeeAdjustmentType(); }
            set { FeeAdjustmentTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "adjustment_type")]
        protected string FeeAdjustmentTypeString { get; set; }

        /// <summary>
        /// If true, the fee applies to custom amounts entered into Square Point of Sale that are not associated with a particular item.
        /// </summary>
        [JsonProperty(PropertyName = "applies_to_custom_amounts")]
        bool AppliesToCustomAmounts { get; set; }

        /// <summary>
        /// If true, the fee is applied to all appropriate items.If false, the fee is not applied at all.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        bool IsEnabled { get; set; }

        /// <summary>
        /// Whether the fee is ADDITIVE or INCLUSIVE.
        /// </summary>
        FeeInclusionType InclusionType
        {
            get { return FeeInclusionTypeString.ToFeeInclusionType(); }
            set { FeeInclusionTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "inclusion_type")]
        protected string FeeInclusionTypeString { get; set; }

        /// <summary>
        /// In countries with multiple classifications for sales taxes, indicates which classification the fee falls under.Currently relevant only to Canadian merchants.
        /// </summary>
        FeeType Type
        {
            get { return FeeTypeString.ToFeeType(); }
            set { FeeTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "type")]
        protected string FeeTypeString { get; set; }
    }
}
