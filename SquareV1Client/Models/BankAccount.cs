using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Represents a merchant's bank account.
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// The bank account's Square-issued ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The Square-issued ID of the merchant associated with the bank account.
        /// </summary>
        [JsonProperty(PropertyName = "merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// The name of the bank that manages the account.
        /// </summary>
        [JsonProperty(PropertyName = "bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The name associated with the bank account.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The bank account's type (for example, savings or checking).
        /// </summary>
        public BankAccountType Type
        {
            get { return TypeString.ToBankAccountType(); }
            set { TypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "type")]
        public string TypeString { get; set; }

        /// <summary>
        /// The bank account's routing number.
        /// </summary>
        [JsonProperty(PropertyName = "routing_number")]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// The last few digits of the bank account number.
        /// </summary>
        [JsonProperty(PropertyName = "account_number_suffix")]
        public string AccountNumberSuffix { get; set; }

        /// <summary>
        /// The currency code of the currency associated with the bank account, in ISO 4217 format.For example, the currency code for US dollars is USD.
        /// </summary>
        [JsonProperty(PropertyName = "currency_code")]
        public string CurrencyCode { get; set; }
    }
}
