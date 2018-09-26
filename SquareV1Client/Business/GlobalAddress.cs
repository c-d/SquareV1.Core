using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Business
{
    /// <summary>
    /// A generic representation of a physical address.
    /// </summary>
    public class GlobalAddress
    {
        /// <summary>
        /// The first line of the address.
        /// </summary>
        /// <remarks>
        /// Fields that start with address_line provide the address's most specific details, like street number, street name, and building name. They do not provide less specific details like city, state/province, or country (these details are provided in other fields).
        /// </remarks>
        [JsonProperty(PropertyName = "address_line_1")]
        string AddressLine1 { get; set; }

        /// <summary>
        /// The second line of the address, if any.
        /// </summary>
        [JsonProperty(PropertyName = "address_line_2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The third line of the address, if any.
        /// </summary>
        [JsonProperty(PropertyName = "address_line_3")]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The fourth line of the address, if any.
        /// </summary>
        [JsonProperty(PropertyName = "address_line_4")]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// The fifth line of the address, if any.
        /// </summary>
        [JsonProperty(PropertyName = "address_line_5")]
        public string AddressLine5 { get; set; }

        /// <summary>
        /// The city or town of the address.
        /// </summary>
        [JsonProperty(PropertyName = "locality")]
        public string Locality { get; set; }

        /// <summary>
        /// A civil region within the address's locality, if any.
        /// </summary>
        [JsonProperty(PropertyName = "sublocality")]
        public string SubLocality { get; set; }

        /// <summary>
        /// A civil region within the address's sublocality, if any.
        /// </summary>
        [JsonProperty(PropertyName = "sublocality_1")]
        public string SubLocality1 { get; set; }

        /// <summary>
        /// A civil region within the address's sublocality_1, if any.
        /// </summary>
        [JsonProperty(PropertyName = "sublocality_2")]
        public string SubLocality2 { get; set; }

        /// <summary>
        /// A civil region within the address's sublocality_2, if any.
        /// </summary>
        [JsonProperty(PropertyName = "sublocality_3")]
        public string SubLocality3 { get; set; }

        /// <summary>
        /// A civil region within the address's sublocality_3, if any.
        /// </summary>
        [JsonProperty(PropertyName = "sublocality_4")]
        public string SubLocality4 { get; set; }

        /// <summary>
        /// A civil region within the address's sublocality_4, if any.
        /// </summary>
        [JsonProperty(PropertyName = "sublocality_5")]
        public string SubLocality5 { get; set; }

        /// <summary>
        /// A civil entity within the address's country. In the United States, this is the state.
        /// </summary>
        [JsonProperty(PropertyName = "administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        /// <summary>
        /// A civil entity within the address's administrative_district_level_1, if any. In the United States, this is the county.
        /// </summary>
        [JsonProperty(PropertyName = "administrative_district_level_2")]
        public string AdministrativeDistrictLevel2 { get; set; }

        /// <summary>
        /// A civil entity within the address's administrative_district_level_2, if any.
        /// </summary>
        [JsonProperty(PropertyName = "administrative_district_level_3")]
        public string AdministrativeDistrictLevel3 { get; set; }

        /// <summary>
        /// The address's postal code.
        /// </summary>
        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The address's country, in ISO 3166-1-alpha-2 format.
        /// </summary>
        [JsonProperty(PropertyName = "country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The coordinates of the address.
        /// </summary>
        [JsonProperty(PropertyName = "address_coordinates")]
        public Coordinates AddressCoordinates { get; set; }
    }
}
