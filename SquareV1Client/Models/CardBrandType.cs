﻿namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// The brand of a credit card.
    /// </summary>
    public enum CardBrandType
    {
        /// <summary>
        /// Any card brand not covered by the other enum values.
        /// </summary>
        OtherBrand,

        /// <summary>
        /// A Visa credit card.
        /// </summary>
        Visa = 0,

        /// <summary>
        /// A MasterCard credit card.
        /// </summary>
        MasterCard,

        /// <summary>
        /// An American Express credit card.
        /// </summary>
        AmericanExpress,

        /// <summary>
        /// A Discover credit card.
        /// </summary>
        Discover,

        /// <summary>
        /// A Diners Club credit card.
        /// </summary>
        DiscoverDiners,

        /// <summary>
        /// A JCB credit card.
        /// </summary>
        Jcb,

        /// <summary>
        /// A China UnionPay credit card.
        /// </summary>
        ChinaUnionPay,

        /// <summary>
        /// A Square gift card.
        /// </summary>
        SquareGiftCard,
    }
}