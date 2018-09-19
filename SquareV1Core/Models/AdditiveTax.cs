using Newtonsoft.Json;
using System;

namespace Meyer.Square.V1.Models
{
    public class Tax
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "rate")]
        public decimal Rate { get; set; }

        public InclusionType InclusionType
        {
            get
            {
                switch (InclusionTypeString)
                {
                    case "ADDITIVE": return InclusionType.Additive;
                    default: throw new InvalidOperationException("Inclusion Type String value is not supported.");
                }
            }
            set
            {
                switch (value)
                {
                    case InclusionType.Additive: InclusionTypeString = "ADDITIVE"; break;
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }

        [JsonProperty(PropertyName = "inclusion_type")]
        protected string InclusionTypeString { get; set; }

        [JsonProperty(PropertyName = "applied_money")]
        public Money AppliedMoney { get; set; }

        [JsonProperty(PropertyName = "fee_id")]
        public string FeeId { get; set; }
    }
}