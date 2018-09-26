using System;

namespace MeyerCorp.Square.V1.Subscription
{
    /// <summary>
    /// Helper methods which make conversion of enum to and from string values required for HTTP/JSON more convenient.
    /// </summary>
    public static class EnumExtensions
    {
        public static string EnumToString(this SurchargeType type)
        {
            switch (type)
            {
                case SurchargeType.Unknown: return "UNKNOWN";
                case SurchargeType.AutoGratuity: return "AUTO_GRATUITY";
                case SurchargeType.Custom: return "CUSTOM";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static SurchargeType ToDateRangeOrderType(this string value)
        {
            switch (value)
            {
                case "UNKNOWN": return SurchargeType.Unknown;
                case "AUTO_GRATUITY": return SurchargeType.AutoGratuity;
                case "CUSTOM": return SurchargeType.Custom;
                default: throw new ArgumentOutOfRangeException();
            }
        }


        public static string EnumToString(this SubscriptionsStatusType type)
        {
            switch (type)
            {
                case SubscriptionsStatusType.Active: return "ACTIVE";
                case SubscriptionsStatusType.InGrace: return "IN_GRACE";
                case SubscriptionsStatusType.Delinquent: return "DELINQUENT";
                case SubscriptionsStatusType.Canceled: return "CANCELED";
                case SubscriptionsStatusType.Terminated: return "TERMINATED";
                case SubscriptionsStatusType.Other: return "OTHER";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static SubscriptionsStatusType ToSubscriptionsStatusType(this string value)
        {
            switch (value)
            {
                case "ACTIVE": return SubscriptionsStatusType.Active;
                case "IN_GRACE": return SubscriptionsStatusType.InGrace;
                case "DELINQUENT": return SubscriptionsStatusType.Delinquent;
                case "CANCELED": return SubscriptionsStatusType.Canceled;
                case "TERMINATED": return SubscriptionsStatusType.Terminated;
                case "OTHER": return SubscriptionsStatusType.Other;
                default: throw new ArgumentOutOfRangeException();
            }
        }


        public static string EnumToString(this SubscriptionsPaymentMethodType type)
        {
            switch (type)
            {
                case SubscriptionsPaymentMethodType.Active: return "CARD";
                case SubscriptionsPaymentMethodType.InGrace: return "PAYOUT_ADJUSTMENT";
                case SubscriptionsPaymentMethodType.Delinquent: return "OTHER";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static SubscriptionsPaymentMethodType ToSubscriptionsPaymentMethodType(this string value)
        {
            switch (value)
            {
                case "CARD": return SubscriptionsPaymentMethodType.Active;
                case "PAYOUT_ADJUSTMENT": return SubscriptionsPaymentMethodType.InGrace;
                case "OTHER": return SubscriptionsPaymentMethodType.Delinquent;
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}