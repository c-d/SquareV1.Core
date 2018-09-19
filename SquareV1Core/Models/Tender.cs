using Newtonsoft.Json;

namespace Meyer.Square.V1.Models
{
    public class Tender
    {
        [JsonProperty(PropertyName = "type")]
        public CreditCardType Type { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "total_money")]
        public Money TotalMoney { get; set; }

        [JsonProperty(PropertyName = "card_brand")]
        public CardBrandType CardBrand { get; set; }

        [JsonProperty(PropertyName = "pan_suffix")]
        public string PanSuffix { get; set; }

        [JsonProperty(PropertyName = "entry_method")]
        public EntryMethodType EntryMethod { get; set; }

        [JsonProperty(PropertyName = "refunded_money")]
        public Money RefundedMoney { get; set; }

        [JsonProperty(PropertyName = "receipt_url")]
        public string ReceiptUrl { get; set; }

        [JsonProperty(PropertyName = "employee_id")]
        public string EmployeeId{ get; set; }

        [JsonProperty(PropertyName = "is_exchange")]
        public bool IsExchange { get; set; }
    }
}