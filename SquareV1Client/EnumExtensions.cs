using MeyerCorp.Square.V1.Models;
using System;

namespace MeyerCorp.Square.V1
{
    /// <summary>
    /// Helper methods which make conversion of enum to and from string values required for HTTP/JSON more convenient.
    /// </summary>
    public static class EnumExtensions
    {
        public static string EnumToString(this DateRangeOrderType type)
        {
            switch (type)
            {
                case DateRangeOrderType.Ascending:
                    return "ASC";
                case DateRangeOrderType.Descending:
                    return "DESC";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static DateRangeOrderType ToDateRangeOrderType(this string value)
        {
            switch (value)
            {
                case "ASC":
                    return DateRangeOrderType.Ascending;
                case "DESC":
                    return DateRangeOrderType.Descending;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }


        public static string EnumToString(this TenderType type)
        {
            switch (type)
            {
                case TenderType.CreditCard:
                    return "CREDIT_CARD";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static TenderType ToTenderType(this string value)
        {
            switch (value)
            {
                case "CREDIT_CARD":
                    return TenderType.CreditCard;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }


        public static string EnumToString(this EntryMethodType type)
        {
            switch (type)
            {
                case EntryMethodType.Manual:
                    return "MANUAL";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static EntryMethodType ToEntryMethodType(this string value)
        {
            switch (value)
            {
                case "MANUAL":
                    return EntryMethodType.Manual;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }


        public static string EnumToString(this CardBrandType type)
        {
            switch (type)
            {
                case CardBrandType.Visa:
                    return "VISA";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static CardBrandType ToCardBrandType(this string value)
        {
            switch (value)
            {
                case "VISA":
                    return CardBrandType.Visa;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
   }
}
