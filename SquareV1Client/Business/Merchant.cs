using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace MeyerCorp.Square.V1.Business
{
    /// <summary>
    /// Represents a Square merchant account.
    /// </summary>
    public class Merchant
    {
        /// <summary>
        /// The merchant account's unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The name associated with the merchant account.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The email address associated with the merchant account.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Indicates whether the merchant account corresponds to a single-location account(LOCATION) or a business account(BUSINESS). This value is almost always  LOCATION.See Structure of a Square business for more information.
        /// </summary>
        public MerchantAccountType EntryMethod
        {
            get { return MerchantAccountTypeString.ToMerchantAccountType(); }
            set { MerchantAccountTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "account_type")]
        protected string MerchantAccountTypeString { get; set; }

        /// <summary>
        /// Capabilities that are enabled for the merchant's Square account. Capabilities that are not listed in this array are not enabled for the account.
        /// </summary>
        /// <remarks>
        /// Single-location accounts can have: CREDIT_CARD_PROCESSING.
        /// Multi-location accounts can have: CREDIT_CARD_PROCESSING, EMPLOYEE_MANAGEMENT, TIMECARD_MANAGEMENT.
        /// </remarks>
        public IEnumerable<MerchantAccountCapabilityType> MerchantAccountCapabilityType
        {
            get { return MerchantAccountCapabilityTypeStrings.Select(t => t.ToMerchantAccountCapabilityType()); }
            set { MerchantAccountCapabilityTypeStrings = value.Select(v => v.EnumToString()); }
        }

        [JsonProperty(PropertyName = "account_capabilities")]
        protected IEnumerable<string> MerchantAccountCapabilityTypeStrings { get; set; }

        /// <summary>
        /// The country associated with the merchant account, in ISO 3166-1-alpha-2 format.
        /// </summary>
        [JsonProperty(PropertyName = "country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The language associated with the merchant account, in BCP 47 format.
        /// </summary>
        [JsonProperty(PropertyName = "language_code")]
        public string LanguageCode { get; set; }

        /// <summary>
        /// The currency associated with the merchant account, in ISO 4217 format.For example, the currency code for US dollars is USD.
        /// </summary>
        [JsonProperty(PropertyName = "currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The name of the merchant's business.
        /// </summary>
        [JsonProperty(PropertyName = "business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// The address of the merchant's business.
        /// </summary>
        [JsonProperty(PropertyName = "business_address")]
        public GlobalAddress BusinessAddress { get; set; }

        /// <summary>
        /// The phone number of the merchant's business.
        /// </summary>
        [JsonProperty(PropertyName = "business_phone")]
        public PhoneNumber PhoneNumber { get; set; }

        /// <summary>
        /// The type of business operated by the merchant.
        /// </summary>
        public MerchantBusinessType BusinessType
        {
            get { return BusinessTypeString.ToMerchantBusinessType(); }
            set { BusinessTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "business_type")]
        protected string BusinessTypeString { get; set; }

        /// <summary>
        /// The merchant's shipping address.
        /// </summary>
        [JsonProperty(PropertyName = "shipping_address")]
        public GlobalAddress ShippingAddress { get; set; }

        /// <summary>
        /// Additional information for a single-location account specified by its associated business account, if it has one.
        /// </summary>
        /// <remarks>
        /// Never included in Merchant objects with the account_type BUSINESS.
        /// </remarks>
        [JsonProperty(PropertyName = "location_details")]
        public MerchantLocationDetails LocationDetails { get; set; }

        /// <summary>
        /// The URL of the merchant's online store.
        /// </summary>
        [JsonProperty(PropertyName = "market_url")]
        public string MarketUrl { get; set; }
    }
}
