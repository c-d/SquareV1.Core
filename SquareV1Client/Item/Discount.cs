using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Item
{
    /// <summary>
    /// Represents a discount that can be applied to a payment. A discount can be either a percentage or a flat amount. You can determine a particular discount's type by checking which of rate or amount_money is included in the object.
    /// </summary>
    public class Discount
    {
        /// <summary>
        /// The discount's unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        string Id { get; set; }

        /// <summary>
        /// The discount's name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        string Name { get; set; }

        /// <summary>
        /// The rate of the discount, as a string representation of a decimal number.A value of  0.07 corresponds to a rate of 7%. This rate is 0 if discount_type is VARIABLE_PERCENTAGE.
        /// </summary>
        /// <remarks>
        /// This field is not included for amount-based discounts.
        ///</remarks>
        [JsonProperty(PropertyName = "rate")]
        public string Rate { get; set; }

        /// <summary>
        /// The amount of the discount.This amount is 0 if discount_type is  VARIABLE_AMOUNT.
        /// </summary>
        /// <remarks>
        /// This field is not included for rate-based discounts.
        ///</remarks>
        [JsonProperty(PropertyName = "amount_money")]
        public Money AmountMoney { get; set; }

        /// <summary>
        /// Indicates whether the discount is a FIXED value or entered at the time of sale.
        /// </summary>
        public DiscountType DiscountType
        {
            get { return DiscountTypeString.ToDiscountType(); }
            set { DiscountTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "discount_type")]
        protected string DiscountTypeString { get; set; }


        /// <summary>
        /// Indicates whether a mobile staff member needs to enter their PIN to apply the discount to a payment.
        /// </summary>
        [JsonProperty(PropertyName = "pin_required")]
        public bool IsPinRequired { get; set; }

        /// <summary>
        /// The color of the discount's display label in Square Point of Sale, if not the default color.
        /// </summary>
        /// <remarks>
        /// The default color is 9da2a6.
        /// </remarks>
        public ItemColorType Color
        {
            get { return ItemColorTypeString.ToItemColorType(); }
            set { ItemColorTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "color")]
        protected string ItemColorTypeString { get; set; }

    }
}