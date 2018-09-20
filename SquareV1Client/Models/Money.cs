using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Models
{
    public class Money
    {
        [JsonProperty(PropertyName = "amount")]
        public long Amount { get; set; }

        public CurrencyCodeType Type
        {
            get { return CurrencyCodeString.ToCurrencyCodeType(); }
            set { CurrencyCodeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "currency_code")]
        protected string CurrencyCodeString { get; set; }
    }
}