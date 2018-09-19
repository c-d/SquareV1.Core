using System;

namespace Meyer.Square.V1.Models
{
    public class Tax
    {
        public string Name { get; set; }
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
        protected string InclusionTypeString { get; set; }
        public Money AppliedMoney { get; set; }
        public string FeeId { get; set; }
    }
}