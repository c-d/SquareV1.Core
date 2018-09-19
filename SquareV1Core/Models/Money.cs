﻿using Newtonsoft.Json;

namespace Meyer.Square.V1.Models
{
    public class Money
    {
        [JsonProperty(PropertyName = "amount")]
        public long Amount { get; set; }

        [JsonProperty(PropertyName = "currency_code")]
        public string CurrencyCode { get; set; }
    }
}