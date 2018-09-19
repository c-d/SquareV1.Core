using Newtonsoft.Json;
using System;

namespace MeyerCorp.Square.V1.Models
{
    public class Tender
    {
        public TenderType Type
        {
            get { return TypeString.ToTenderType(); }
            set { TypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "type")]
        public string TypeString { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "total_money")]
        public Money TotalMoney { get; set; }

        public CardBrandType CardBrand
        {
            get { return CardBrandTypeString.ToCardBrandType(); }
            set { CardBrandTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "card_brand")]
        public string CardBrandTypeString { get; set; }

        [JsonProperty(PropertyName = "pan_suffix")]
        public string PanSuffix { get; set; }

        public EntryMethodType EntryMethod
        {
            get { return EntryMethodTypeString.ToEntryMethodType(); }
            set { EntryMethodTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "entry_method")]
        public string EntryMethodTypeString { get; set; }

        [JsonProperty(PropertyName = "refunded_money")]
        public Money RefundedMoney { get; set; }

        [JsonProperty(PropertyName = "receipt_url")]
        public string ReceiptUrl { get; set; }

        [JsonProperty(PropertyName = "employee_id")]
        public string EmployeeId { get; set; }

        [JsonProperty(PropertyName = "is_exchange")]
        public bool IsExchange { get; set; }
    }
}