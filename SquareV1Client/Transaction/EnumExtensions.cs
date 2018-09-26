using MeyerCorp.Square.V1.Item;
using System;

namespace MeyerCorp.Square.V1.Transaction
{
    /// <summary>
    /// Helper methods which make conversion of enum to and from string values required for HTTP/JSON more convenient.
    /// </summary>
    public static class EnumExtensions
    {
        public static string EnumToString(this TenderType type)
        {
            switch (type)
            {
                case TenderType.CreditCard: return "CREDIT_CARD";
                case TenderType.Cash: return "CASH";
                case TenderType.ThirdPartyCard: return "THIRD_PARTY_CARD";
                case TenderType.NoSale: return "NO_SALE";
                case TenderType.SquareWallet: return "SQUARE_WALLET";
                case TenderType.SquareGiftCard: return "SQUARE_GIFT_CARD";
                case TenderType.Unknown: return "UNKNOWN";
                case TenderType.Other: return "OTHER";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static TenderType ToTenderType(this string value)
        {
            switch (value)
            {
                case "CREDIT_CARD": return TenderType.CreditCard;
                case "CASH": return TenderType.Cash;
                case "THIRD_PARTY_CARD": return TenderType.ThirdPartyCard;
                case "NO_SALE": return TenderType.NoSale;
                case "SQUARE_WALLET": return TenderType.SquareWallet;
                case "SQUARE_GIFT_CARD": return TenderType.SquareGiftCard;
                case "UNKNOWN": return TenderType.Unknown;
                case "OTHER": return TenderType.Other;
                default: throw new ArgumentOutOfRangeException();
            }
        }


        public static string EnumToString(this EntryMethodType type)
        {
            switch (type)
            {
                case EntryMethodType.Manual: return "MANUAL";
                case EntryMethodType.Other: return "OTHER";
                case EntryMethodType.Scanned: return "SCANNED";
                case EntryMethodType.SquareCash: return "SQUARE_CASH";
                case EntryMethodType.SquareWallet: return "SQUARE_WALLET";
                case EntryMethodType.Swiped: return "SWIPED";
                case EntryMethodType.WebForm: return "WEB_FORM";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static EntryMethodType ToEntryMethodType(this string value)
        {
            switch (value)
            {
                case "MANUAL": return EntryMethodType.Manual;
                case "OTHER": return EntryMethodType.Other;
                case "SCANNED": return EntryMethodType.Scanned;
                case "SQUARE_CASH": return EntryMethodType.SquareCash;
                case "SQUARE_WALLET": return EntryMethodType.SquareWallet;
                case "SWIPED": return EntryMethodType.Swiped;
                case "WEB_FORM": return EntryMethodType.WebForm;
                default: throw new ArgumentOutOfRangeException();
            }
        }


        public static string EnumToString(this TenderCardBrandType type)
        {
            switch (type)
            {
                case TenderCardBrandType.OtherBrand: return "OTHER_BRAND";
                case TenderCardBrandType.Visa: return "VISA";
                case TenderCardBrandType.MasterCard: return "MASTER_CARD";
                case TenderCardBrandType.AmericanExpress: return "AMERICAN_EXPRESS";
                case TenderCardBrandType.Discover: return "DISCOVER";
                case TenderCardBrandType.DiscoverDiners: return "DISCOVER_DINERS";
                case TenderCardBrandType.Jcb: return "JCB";
                case TenderCardBrandType.ChinaUnionPay: return "CHINA_UNIONPAY";
                case TenderCardBrandType.SquareGiftCard: return "SQUARE_GIFT_CARD";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static TenderCardBrandType ToCardBrandType(this string value)
        {
            switch (value)
            {
                case "OTHER_BRAND": return TenderCardBrandType.OtherBrand;
                case "VISA": return TenderCardBrandType.Visa;
                case "MASTER_CARD": return TenderCardBrandType.MasterCard;
                case "AMERICAN_EXPRESS": return TenderCardBrandType.AmericanExpress;
                case "DISCOVER": return TenderCardBrandType.Discover;
                case "DISCOVER_DINERS": return TenderCardBrandType.DiscoverDiners;
                case "JCB": return TenderCardBrandType.Jcb;
                case "CHINA_UNIONPAY": return TenderCardBrandType.ChinaUnionPay;
                case "SQUARE_GIFT_CARD": return TenderCardBrandType.SquareGiftCard;
                default: throw new ArgumentOutOfRangeException();
            }
        }


        public static string EnumToString(this RefundType type)
        {
            switch (type)
            {
                case RefundType.Full: return "FULL";
                case RefundType.Partial: return "PARTIAL";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static RefundType ToRefundType(this string value)
        {
            switch (value)
            {
                case "FULL": return RefundType.Full;
                case "PARTIAL": return RefundType.Partial;
                default: throw new ArgumentOutOfRangeException();
            }
        }


        public static string EnumToString(this PaymentItemizationType type)
        {
            switch (type)
            {
                case PaymentItemizationType.CustomAmount: return "CUSTOM_AMOUNT";
                case PaymentItemizationType.GiftCardActivation: return "GIFT_CARD_ACTIVATION";
                case PaymentItemizationType.GiftCardReload: return "GIFT_CARD_RELOAD";
                case PaymentItemizationType.GiftCardUnkown: return "GIFT_CARD_UNKNOWN";
                case PaymentItemizationType.Item: return "ITEM";
                case PaymentItemizationType.Other: return "OTHER";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static PaymentItemizationType ToPaymentItemizationType(this string value)
        {
            switch (value)
            {
                case "CUSTOM_AMOUNT": return PaymentItemizationType.CustomAmount;
                case "GIFT_CARD_ACTIVATION": return PaymentItemizationType.GiftCardActivation;
                case "GIFT_CARD_RELOAD": return PaymentItemizationType.GiftCardReload;
                case "GIFT_CARD_UNKNOWN": return PaymentItemizationType.GiftCardUnkown;
                case "ITEM": return PaymentItemizationType.Item;
                case "OTHER": return PaymentItemizationType.Other;
                default: throw new ArgumentOutOfRangeException();
            }
        }


        public static string EnumToString(this BankAccountType type)
        {
            switch (type)
            {
                case BankAccountType.BusinessChecking: return "BUSINESS_CHECKING";
                case BankAccountType.Checking: return "CHECKING";
                case BankAccountType.Investment: return "INVESTMENT";
                case BankAccountType.Loan: return "LOAN";
                case BankAccountType.Savings: return "SAVINGS";
                case BankAccountType.Other: return "OTHER";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static BankAccountType ToBankAccountType(this string value)
        {
            switch (value)
            {
                case "BUSINESS_CHECKING": return BankAccountType.BusinessChecking;
                case "CHECKING": return BankAccountType.Checking;
                case "INVESTMENT": return BankAccountType.Investment;
                case "LOAN": return BankAccountType.Loan;
                case "SAVINGS": return BankAccountType.Savings;
                case "OTHER": return BankAccountType.Other;
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}