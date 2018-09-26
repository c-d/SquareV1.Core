namespace MeyerCorp.Square.V1
{
    /// <summary>
    /// Indicates which sales tax classification the fee falls under.
    /// </summary>
    /// <remarks>
    /// Currently relevant only to Canadian merchants.
    /// </remarks>
    public enum FeeType
    {
        /// <summary>
        /// The fee is a Goods and Services Tax (GST).
        /// </summary>
        CanadianGoodsAndServicesTax,

        /// <summary>
        /// The fee is a Harmonized Sales Tax (HST).
        /// </summary>
        CaliforniaHarmonizedSalesTax,

        /// <summary>
        /// The fee is a Prince Edward Island provincial sales tax.
        /// </summary>
        PrinceEdwardIslandProvincialSalesTax,

        /// <summary>
        /// The fee is a provincial sales tax (PST).
        /// </summary>
        ProvincialSaleTax,

        /// <summary>
        /// The fee is a Quebec Sales Tax (QST).
        /// </summary>
        QuebecSalesTax,

        /// <summary>
        /// The fee is a Japanese consumption tax. All fees created by Japanese merchants have this type.
        /// </summary>
        JapaneseConsumptionTax,

        /// <summary>
        /// The fee is a US sales tax. All fees created by US merchants have this type.
        /// </summary>
        UsSalesTax,

        /// <summary>
        /// The fee is a type that does not match any other value.
        /// </summary>
        Other
    }
}
