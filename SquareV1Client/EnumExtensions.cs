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


        public static string EnumToString(this CardBrandType type)
        {
            switch (type)
            {
                case CardBrandType.OtherBrand: return "OTHER_BRAND";
                case CardBrandType.Visa: return "VISA";
                case CardBrandType.MasterCard: return "MASTER_CARD";
                case CardBrandType.AmericanExpress: return "AMERICAN_EXPRESS";
                case CardBrandType.Discover: return "DISCOVER";
                case CardBrandType.DiscoverDiners: return "DISCOVER_DINERS";
                case CardBrandType.Jcb: return "JCB";
                case CardBrandType.ChinaUnionPay: return "CHINA_UNIONPAY";
                case CardBrandType.SquareGiftCard: return "SQUARE_GIFT_CARD";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static CardBrandType ToCardBrandType(this string value)
        {
            switch (value)
            {
                case "OTHER_BRAND": return CardBrandType.OtherBrand;
                case "VISA": return CardBrandType.Visa;
                case "MASTER_CARD": return CardBrandType.MasterCard;
                case "AMERICAN_EXPRESS": return CardBrandType.AmericanExpress;
                case "DISCOVER": return CardBrandType.Discover;
                case "DISCOVER_DINERS": return CardBrandType.DiscoverDiners;
                case "JCB": return CardBrandType.Jcb;
                case "CHINA_UNIONPAY": return CardBrandType.ChinaUnionPay;
                case "SQUARE_GIFT_CARD": return CardBrandType.SquareGiftCard;
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


        public static string EnumToString(this CurrencyCodeType type)
        {
            switch (type)
            {
                case CurrencyCodeType.CAD: return "CAD";
                case CurrencyCodeType.JPY: return "JPY";
                case CurrencyCodeType.USD: return "USD";
                case CurrencyCodeType.AED: return "AED";
                case CurrencyCodeType.ALL: return "ALL";
                case CurrencyCodeType.AMD: return "AMD";
                case CurrencyCodeType.AOA: return "AOA";
                case CurrencyCodeType.ARS: return "ARS";
                case CurrencyCodeType.AUD: return "AUD";
                case CurrencyCodeType.AWG: return "AWG";
                case CurrencyCodeType.AZN: return "AZN";
                case CurrencyCodeType.BAM: return "BAM";
                case CurrencyCodeType.BBD: return "BBD";
                case CurrencyCodeType.BDT: return "BDT";
                case CurrencyCodeType.BGN: return "BGN";
                case CurrencyCodeType.BHD: return "BHD";
                case CurrencyCodeType.BMD: return "BMD";
                case CurrencyCodeType.BND: return "BND";
                case CurrencyCodeType.BOB: return "BOB";
                case CurrencyCodeType.BRL: return "BRL";
                case CurrencyCodeType.BSD: return "BSD";
                case CurrencyCodeType.BTN: return "BTN";
                case CurrencyCodeType.BWP: return "BWP";
                case CurrencyCodeType.BYR: return "BYR";
                case CurrencyCodeType.BZD: return "BZD";
                case CurrencyCodeType.CDF: return "CDF";
                case CurrencyCodeType.CHF: return "CHF";
                case CurrencyCodeType.CLP: return "CLP";
                case CurrencyCodeType.CNY: return "CNY";
                case CurrencyCodeType.COP: return "COP";
                case CurrencyCodeType.CRC: return "CRC";
                case CurrencyCodeType.CVE: return "CVE";
                case CurrencyCodeType.CZK: return "CZK";
                case CurrencyCodeType.DKK: return "DKK";
                case CurrencyCodeType.DOP: return "DOP";
                case CurrencyCodeType.DZD: return "DZD";
                case CurrencyCodeType.EGP: return "EGP";
                case CurrencyCodeType.ETB: return "ETB";
                case CurrencyCodeType.EUR: return "EUR";
                case CurrencyCodeType.FJD: return "FJD";
                case CurrencyCodeType.GBP: return "GBP";
                case CurrencyCodeType.GEL: return "GEL";
                case CurrencyCodeType.GHS: return "GHS";
                case CurrencyCodeType.GIP: return "GIP";
                case CurrencyCodeType.GMD: return "GMD";
                case CurrencyCodeType.GTQ: return "GTQ";
                case CurrencyCodeType.GYD: return "GYD";
                case CurrencyCodeType.HKD: return "HKD";
                case CurrencyCodeType.HNL: return "HNL";
                case CurrencyCodeType.HRK: return "HRK";
                case CurrencyCodeType.HTG: return "HTG";
                case CurrencyCodeType.HUF: return "HUF";
                case CurrencyCodeType.IDR: return "IDR";
                case CurrencyCodeType.ILS: return "ILS";
                case CurrencyCodeType.INR: return "INR";
                case CurrencyCodeType.ISK: return "ISK";
                case CurrencyCodeType.JMD: return "JMD";
                case CurrencyCodeType.JOD: return "JOD";
                case CurrencyCodeType.KES: return "KES";
                case CurrencyCodeType.KGS: return "KGS";
                case CurrencyCodeType.KHR: return "KHR";
                case CurrencyCodeType.KRW: return "KRW";
                case CurrencyCodeType.KWD: return "KWD";
                case CurrencyCodeType.KYD: return "KYD";
                case CurrencyCodeType.KZT: return "KZT";
                case CurrencyCodeType.LAK: return "LAK";
                case CurrencyCodeType.LBP: return "LBP";
                case CurrencyCodeType.LKR: return "LKR";
                case CurrencyCodeType.LRD: return "LRD";
                case CurrencyCodeType.LTL: return "LTL";
                case CurrencyCodeType.MAD: return "MAD";
                case CurrencyCodeType.MDL: return "MDL";
                case CurrencyCodeType.MGA: return "MGA";
                case CurrencyCodeType.MKD: return "MKD";
                case CurrencyCodeType.MMK: return "MMK";
                case CurrencyCodeType.MNT: return "MNT";
                case CurrencyCodeType.MOP: return "MOP";
                case CurrencyCodeType.MRO: return "MRO";
                case CurrencyCodeType.MUR: return "MUR";
                case CurrencyCodeType.MWK: return "MWK";
                case CurrencyCodeType.MXN: return "MXN";
                case CurrencyCodeType.MYR: return "MYR";
                case CurrencyCodeType.MZN: return "MZN";
                case CurrencyCodeType.NAD: return "NAD";
                case CurrencyCodeType.NGN: return "NGN";
                case CurrencyCodeType.NIO: return "NIO";
                case CurrencyCodeType.NOK: return "NOK";
                case CurrencyCodeType.NPR: return "NPR";
                case CurrencyCodeType.NZD: return "NZD";
                case CurrencyCodeType.OMR: return "OMR";
                case CurrencyCodeType.PAB: return "PAB";
                case CurrencyCodeType.PEN: return "PEN";
                case CurrencyCodeType.PGK: return "PGK";
                case CurrencyCodeType.PHP: return "PHP";
                case CurrencyCodeType.PKR: return "PKR";
                case CurrencyCodeType.PLN: return "PLN";
                case CurrencyCodeType.PYG: return "PYG";
                case CurrencyCodeType.QAR: return "QAR";
                case CurrencyCodeType.RON: return "RON";
                case CurrencyCodeType.RSD: return "RSD";
                case CurrencyCodeType.RUB: return "RUB";
                case CurrencyCodeType.RWF: return "RWF";
                case CurrencyCodeType.SAR: return "SAR";
                case CurrencyCodeType.SBD: return "SBD";
                case CurrencyCodeType.SCR: return "SCR";
                case CurrencyCodeType.SEK: return "SEK";
                case CurrencyCodeType.SGD: return "SGD";
                case CurrencyCodeType.SLL: return "SLL";
                case CurrencyCodeType.SRD: return "SRD";
                case CurrencyCodeType.STD: return "STD";
                case CurrencyCodeType.SVC: return "SVC";
                case CurrencyCodeType.SZL: return "SZL";
                case CurrencyCodeType.THB: return "THB";
                case CurrencyCodeType.TJS: return "TJS";
                case CurrencyCodeType.TMT: return "TMT";
                case CurrencyCodeType.TND: return "TND";
                case CurrencyCodeType.TRY: return "TRY";
                case CurrencyCodeType.TTD: return "TTD";
                case CurrencyCodeType.TWD: return "TWD";
                case CurrencyCodeType.TZS: return "TZS";
                case CurrencyCodeType.UAH: return "UAH";
                case CurrencyCodeType.UGX: return "UGX";
                case CurrencyCodeType.UYU: return "UYU";
                case CurrencyCodeType.UZS: return "UZS";
                case CurrencyCodeType.VEF: return "VEF";
                case CurrencyCodeType.VND: return "VND";
                case CurrencyCodeType.XAF: return "XAF";
                case CurrencyCodeType.XCD: return "XCD";
                case CurrencyCodeType.XOF: return "XOF";
                case CurrencyCodeType.YER: return "YER";
                case CurrencyCodeType.ZAR: return "ZAR";
                case CurrencyCodeType.ZMW: return "ZMW";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static MerchantAccountType ToCurrencyCodeType(this string value)
        {
            switch (value)
            {
                case "CAD": return CurrencyCodeType.CAD;
                case "JPY": return CurrencyCodeType.JPY;
                case "USD": return CurrencyCodeType.USD;
                case "AED": return CurrencyCodeType.AED;
                case "ALL": return CurrencyCodeType.ALL;
                case "AMD": return CurrencyCodeType.AMD;
                case "AOA": return CurrencyCodeType.AOA;
                case "ARS": return CurrencyCodeType.ARS;
                case "AUD": return CurrencyCodeType.AUD;
                case "AWG": return CurrencyCodeType.AWG;
                case "AZN": return CurrencyCodeType.AZN;
                case "BAM": return CurrencyCodeType.BAM;
                case "BBD": return CurrencyCodeType.BBD;
                case "BDT": return CurrencyCodeType.BDT;
                case "BGN": return CurrencyCodeType.BGN;
                case "BHD": return CurrencyCodeType.BHD;
                case "BMD": return CurrencyCodeType.BMD;
                case "BND": return CurrencyCodeType.BND;
                case "BOB": return CurrencyCodeType.BOB;
                case "BRL": return CurrencyCodeType.BRL;
                case "BSD": return CurrencyCodeType.BSD;
                case "BTN": return CurrencyCodeType.BTN;
                case "BWP": return CurrencyCodeType.BWP;
                case "BYR": return CurrencyCodeType.BYR;
                case "BZD": return CurrencyCodeType.BZD;
                case "CDF": return CurrencyCodeType.CDF;
                case "CHF": return CurrencyCodeType.CHF;
                case "CLP": return CurrencyCodeType.CLP;
                case "CNY": return CurrencyCodeType.CNY;
                case "COP": return CurrencyCodeType.COP;
                case "CRC": return CurrencyCodeType.CRC;
                case "CVE": return CurrencyCodeType.CVE;
                case "CZK": return CurrencyCodeType.CZK;
                case "DKK": return CurrencyCodeType.DKK;
                case "DOP": return CurrencyCodeType.DOP;
                case "DZD": return CurrencyCodeType.DZD;
                case "EGP": return CurrencyCodeType.EGP;
                case "ETB": return CurrencyCodeType.ETB;
                case "EUR": return CurrencyCodeType.EUR;
                case "FJD": return CurrencyCodeType.FJD;
                case "GBP": return CurrencyCodeType.GBP;
                case "GEL": return CurrencyCodeType.GEL;
                case "GHS": return CurrencyCodeType.GHS;
                case "GIP": return CurrencyCodeType.GIP;
                case "GMD": return CurrencyCodeType.GMD;
                case "GTQ": return CurrencyCodeType.GTQ;
                case "GYD": return CurrencyCodeType.GYD;
                case "HKD": return CurrencyCodeType.HKD;
                case "HNL": return CurrencyCodeType.HNL;
                case "HRK": return CurrencyCodeType.HRK;
                case "HTG": return CurrencyCodeType.HTG;
                case "HUF": return CurrencyCodeType.HUF;
                case "IDR": return CurrencyCodeType.IDR;
                case "ILS": return CurrencyCodeType.ILS;
                case "INR": return CurrencyCodeType.INR;
                case "ISK": return CurrencyCodeType.ISK;
                case "JMD": return CurrencyCodeType.JMD;
                case "JOD": return CurrencyCodeType.JOD;
                case "KES": return CurrencyCodeType.KES;
                case "KGS": return CurrencyCodeType.KGS;
                case "KHR": return CurrencyCodeType.KHR;
                case "KRW": return CurrencyCodeType.KRW;
                case "KWD": return CurrencyCodeType.KWD;
                case "KYD": return CurrencyCodeType.KYD;
                case "KZT": return CurrencyCodeType.KZT;
                case "LAK": return CurrencyCodeType.LAK;
                case "LBP": return CurrencyCodeType.LBP;
                case "LKR": return CurrencyCodeType.LKR;
                case "LRD": return CurrencyCodeType.LRD;
                case "LTL": return CurrencyCodeType.LTL;
                case "MAD": return CurrencyCodeType.MAD;
                case "MDL": return CurrencyCodeType.MDL;
                case "MGA": return CurrencyCodeType.MGA;
                case "MKD": return CurrencyCodeType.MKD;
                case "MMK": return CurrencyCodeType.MMK;
                case "MNT": return CurrencyCodeType.MNT;
                case "MOP": return CurrencyCodeType.MOP;
                case "MRO": return CurrencyCodeType.MRO;
                case "MUR": return CurrencyCodeType.MUR;
                case "MWK": return CurrencyCodeType.MWK;
                case "MXN": return CurrencyCodeType.MXN;
                case "MYR": return CurrencyCodeType.MYR;
                case "MZN": return CurrencyCodeType.MZN;
                case "NAD": return CurrencyCodeType.NAD;
                case "NGN": return CurrencyCodeType.NGN;
                case "NIO": return CurrencyCodeType.NIO;
                case "NOK": return CurrencyCodeType.NOK;
                case "NPR": return CurrencyCodeType.NPR;
                case "NZD": return CurrencyCodeType.NZD;
                case "OMR": return CurrencyCodeType.OMR;
                case "PAB": return CurrencyCodeType.PAB;
                case "PEN": return CurrencyCodeType.PEN;
                case "PGK": return CurrencyCodeType.PGK;
                case "PHP": return CurrencyCodeType.PHP;
                case "PKR": return CurrencyCodeType.PKR;
                case "PLN": return CurrencyCodeType.PLN;
                case "PYG": return CurrencyCodeType.PYG;
                case "QAR": return CurrencyCodeType.QAR;
                case "RON": return CurrencyCodeType.RON;
                case "RSD": return CurrencyCodeType.RSD;
                case "RUB": return CurrencyCodeType.RUB;
                case "RWF": return CurrencyCodeType.RWF;
                case "SAR": return CurrencyCodeType.SAR;
                case "SBD": return CurrencyCodeType.SBD;
                case "SCR": return CurrencyCodeType.SCR;
                case "SEK": return CurrencyCodeType.SEK;
                case "SGD": return CurrencyCodeType.SGD;
                case "SLL": return CurrencyCodeType.SLL;
                case "SRD": return CurrencyCodeType.SRD;
                case "STD": return CurrencyCodeType.STD;
                case "SVC": return CurrencyCodeType.SVC;
                case "SZL": return CurrencyCodeType.SZL;
                case "THB": return CurrencyCodeType.THB;
                case "TJS": return CurrencyCodeType.TJS;
                case "TMT": return CurrencyCodeType.TMT;
                case "TND": return CurrencyCodeType.TND;
                case "TRY": return CurrencyCodeType.TRY;
                case "TTD": return CurrencyCodeType.TTD;
                case "TWD": return CurrencyCodeType.TWD;
                case "TZS": return CurrencyCodeType.TZS;
                case "UAH": return CurrencyCodeType.UAH;
                case "UGX": return CurrencyCodeType.UGX;
                case "UYU": return CurrencyCodeType.UYU;
                case "UZS": return CurrencyCodeType.UZS;
                case "VEF": return CurrencyCodeType.VEF;
                case "VND": return CurrencyCodeType.VND;
                case "XAF": return CurrencyCodeType.XAF;
                case "XCD": return CurrencyCodeType.XCD;
                case "XOF": return CurrencyCodeType.XOF;
                case "YER": return CurrencyCodeType.YER;
                case "ZAR": return CurrencyCodeType.ZAR;
                case "ZMW": return CurrencyCodeType.ZMW;
                default: throw new ArgumentOutOfRangeException();
            }
        }


        public static string EnumToString(this MerchantAccountType type)
        {
            switch (type)
            {
                case MerchantAccountType.Business: return "BUSINESS";
                case MerchantAccountType.Location: return "LOCATION";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static MerchantAccountType ToMerchantAccountType(this string value)
        {
            switch (value)
            {
                case "BUSINESS": return MerchantAccountType.Business;
                case "LOCATION": return MerchantAccountType.Location;
                default: throw new ArgumentOutOfRangeException();
            }
        }


        public static string EnumToString(this MerchantAccountCapabilityType type)
        {
            switch (type)
            {
                case MerchantAccountCapabilityType.CreditCardProcessing: return "CREDIT_CARD_PROCESSING";
                case MerchantAccountCapabilityType.EmployeeManagement: return "EMPLOYEE_MANAGEMENT";
                case MerchantAccountCapabilityType.TimecardManagement: return "TIMECARD_MANAGEMENT";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static MerchantAccountCapabilityType ToMerchantAccountCapabilityType(this string value)
        {
            switch (value)
            {
                case "CREDIT_CARD_PROCESSING": return MerchantAccountCapabilityType.CreditCardProcessing;
                case "EMPLOYEE_MANAGEMENT": return MerchantAccountCapabilityType.EmployeeManagement;
                case "TIMECARD_MANAGEMENT": return MerchantAccountCapabilityType.TimecardManagement;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static string EnumToString(this MerchantBusinessType type)
        {
            switch (type)
            {
                case MerchantBusinessType.Accounting: return "ACCOUNTING";
                case MerchantBusinessType.ApparelAndAccessoryShops: return "APPAREL_AND_ACCESSORY_SHOPS";
                case MerchantBusinessType.ArtDealersGalleries: return "ART_DEALERS_GALLERIES";
                case MerchantBusinessType.ArtDesignAndPhotography: return "ART_DESIGN_AND_PHOTOGRAPHY";
                case MerchantBusinessType.BarClubLounge: return "BAR_CLUB_LOUNGE";
                case MerchantBusinessType.BeautyAndBarberShops: return "BEAUTY_AND_BARBER_SHOPS";
                case MerchantBusinessType.BookStores: return "BOOK_STORES";
                case MerchantBusinessType.BusinessServices: return "BUSINESS_SERVICES";
                case MerchantBusinessType.Catering: return "CATERING";
                case MerchantBusinessType.CharitableSocialServiceOrganizations: return "CHARITABLE_SOCIAL_SERVICE_ORGANIZATIONS";
                case MerchantBusinessType.CharitableOrgs: return "CHARITIBLE_ORGS";
                case MerchantBusinessType.CleaningServices: return "CLEANING_SERVICES";
                case MerchantBusinessType.ComputerEquipmentSoftwareMaitenanceRepairServices: return "COMPUTER_EQUIPMENT_SOFTWARE_MAINTENANCE_REPAIR_SERVICES";
                case MerchantBusinessType.Consultant: return "CONSULTANT";
                case MerchantBusinessType.Contractors: return "CONTRACTORS";
                case MerchantBusinessType.DeliveryServices: return "DELIVERY_SERVICES";
                case MerchantBusinessType.Dentistry: return "DENTISTRY";
                case MerchantBusinessType.Education: return "EDUCATION";
                case MerchantBusinessType.FoodStoresConvenienceStoresAndSpeciatyMarkets: return "FOOD_STORES_CONVENIENCE_STORES_AND_SPECIALTY_MARKETS";
                case MerchantBusinessType.FoodTruckCart: return "FOOD_TRUCK_CART";
                case MerchantBusinessType.FurnitureHomeAndOfficeEquipment: return "FURNITURE_HOME_AND_OFFICE_EQUIPMENT";
                case MerchantBusinessType.FurnitureHomeGoods: return "FURNITURE_HOME_GOODS";
                case MerchantBusinessType.HotelsAndLoding: return "HOTELS_AND_LODGING";
                case MerchantBusinessType.IndividualUse: return "INDIVIDUAL_USE";
                case MerchantBusinessType.JewelryAndWatches: return "JEWELRY_AND_WATCHES";
                case MerchantBusinessType.LandscapingAndHorticulturalServices: return "LANDSCAPING_AND_HORTICULTURAL_SERVICES";
                case MerchantBusinessType.LanguageSchools: return "LANGUAGE_SCHOOLS";
                case MerchantBusinessType.LegalServices: return "LEGAL_SERVICES";
                case MerchantBusinessType.MedicalPractitioners: return "MEDICAL_PRACTITIONERS";
                case MerchantBusinessType.MedicalServicesAndHealthPractitioners: return "MEDICAL_SERVICES_AND_HEALTH_PRACTITIONERS";
                case MerchantBusinessType.MembershipOrganizations: return "MEMBERSHIP_ORGANIZATIONS";
                case MerchantBusinessType.MusicAndEntertainment: return "MUSIC_AND_ENTERTAINMENT";
                case MerchantBusinessType.Other: return "OTHER";
                case MerchantBusinessType.OutdoorMakets: return "OUTDOOR_MARKETS";
                case MerchantBusinessType.PersonalServices: return "PERSONAL_SERVICES";
                case MerchantBusinessType.PoliticalOrganizations: return "POLITICAL_ORGANIZATIONS";
                case MerchantBusinessType.ProfessionalServices: return "PROFESSIONAL_SERVICES";
                case MerchantBusinessType.RealEstate: return "REAL_ESTATE";
                case MerchantBusinessType.RecreationServices: return "RECREATION_SERVICES";
                case MerchantBusinessType.RepairShopsAndRelatedServices: return "REPAIR_SHOPS_AND_RELATED_SERVICES";
                case MerchantBusinessType.Restaraunt: return "RESTAURANTS";
                case MerchantBusinessType.RetailShops: return "RETAIL_SHOPS";
                case MerchantBusinessType.SchoolsAndEducationalServices: return "SCHOOLS_AND_EDUCATIONAL_SERVICES";
                case MerchantBusinessType.SportingGoods: return "SPORTING_GOODS";
                case MerchantBusinessType.TaxicabsAndLimousines: return "TAXICABS_AND_LIMOUSINES";
                case MerchantBusinessType.TicketSales: return "TICKET_SALES";
                case MerchantBusinessType.Tourism: return "TOURISM";
                case MerchantBusinessType.TravelTourism: return "TRAVEL_TOURISM";
                case MerchantBusinessType.VeterinaryServices: return "VETERINARY_SERVICES";
                case MerchantBusinessType.WebDevDesign: return "WEB_DEV_DESIGN";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static MerchantBusinessType ToMerchantBusinessType(this string value)
        {
            switch (value)
            {
                case "ACCOUNTING": return MerchantBusinessType.Accounting;
                case "APPAREL_AND_ACCESSORY_SHOPS": return MerchantBusinessType.ApparelAndAccessoryShops;
                case "ART_DEALERS_GALLERIES": return MerchantBusinessType.ArtDealersGalleries;
                case "ART_DESIGN_AND_PHOTOGRAPHY": return MerchantBusinessType.ArtDesignAndPhotography;
                case "BAR_CLUB_LOUNGE": return MerchantBusinessType.BarClubLounge;
                case "BEAUTY_AND_BARBER_SHOPS": return MerchantBusinessType.BeautyAndBarberShops;
                case "BOOK_STORES": return MerchantBusinessType.BookStores;
                case "BUSINESS_SERVICES": return MerchantBusinessType.BusinessServices;
                case "CATERING": return MerchantBusinessType.Catering;
                case "CHARITABLE_SOCIAL_SERVICE_ORGANIZATIONS": return MerchantBusinessType.CharitableSocialServiceOrganizations;
                case "CHARITIBLE_ORGS": return MerchantBusinessType.CharitableOrgs;
                case "CLEANING_SERVICES": return MerchantBusinessType.CleaningServices;
                case "COMPUTER_EQUIPMENT_SOFTWARE_MAINTENANCE_REPAIR_SERVICES": return MerchantBusinessType.ComputerEquipmentSoftwareMaitenanceRepairServices;
                case "CONSULTANT": return MerchantBusinessType.Consultant;
                case "CONTRACTORS": return MerchantBusinessType.Contractors;
                case "DELIVERY_SERVICES": return MerchantBusinessType.DeliveryServices;
                case "DENTISTRY": return MerchantBusinessType.Dentistry;
                case "EDUCATION": return MerchantBusinessType.Education;
                case "FOOD_STORES_CONVENIENCE_STORES_AND_SPECIALTY_MARKETS": return MerchantBusinessType.FoodStoresConvenienceStoresAndSpeciatyMarkets;
                case "FOOD_TRUCK_CART": return MerchantBusinessType.FoodTruckCart;
                case "FURNITURE_HOME_AND_OFFICE_EQUIPMENT": return MerchantBusinessType.FurnitureHomeAndOfficeEquipment;
                case "FURNITURE_HOME_GOODS": return MerchantBusinessType.FurnitureHomeGoods;
                case "HOTELS_AND_LODGING": return MerchantBusinessType.HotelsAndLoding;
                case "INDIVIDUAL_USE": return MerchantBusinessType.IndividualUse;
                case "JEWELRY_AND_WATCHES": return MerchantBusinessType.JewelryAndWatches;
                case "LANDSCAPING_AND_HORTICULTURAL_SERVICES": return MerchantBusinessType.LandscapingAndHorticulturalServices;
                case "LANGUAGE_SCHOOLS": return MerchantBusinessType.LanguageSchools;
                case "LEGAL_SERVICES": return MerchantBusinessType.LegalServices;
                case "MEDICAL_PRACTITIONERS": return MerchantBusinessType.MedicalPractitioners;
                case "MEDICAL_SERVICES_AND_HEALTH_PRACTITIONERS": return MerchantBusinessType.MedicalServicesAndHealthPractitioners;
                case "MEMBERSHIP_ORGANIZATIONS": return MerchantBusinessType.MembershipOrganizations;
                case "MUSIC_AND_ENTERTAINMENT": return MerchantBusinessType.MusicAndEntertainment;
                case "OTHER": return MerchantBusinessType.Other;
                case "OUTDOOR_MARKETS": return MerchantBusinessType.OutdoorMakets;
                case "PERSONAL_SERVICES": return MerchantBusinessType.PersonalServices;
                case "POLITICAL_ORGANIZATIONS": return MerchantBusinessType.PoliticalOrganizations;
                case "PROFESSIONAL_SERVICES": return MerchantBusinessType.ProfessionalServices;
                case "REAL_ESTATE": return MerchantBusinessType.RealEstate;
                case "RECREATION_SERVICES": return MerchantBusinessType.RecreationServices;
                case "REPAIR_SHOPS_AND_RELATED_SERVICES": return MerchantBusinessType.RepairShopsAndRelatedServices;
                case "RESTAURANTS": return MerchantBusinessType.Restaraunt;
                case "RETAIL_SHOPS": return MerchantBusinessType.RetailShops;
                case "SCHOOLS_AND_EDUCATIONAL_SERVICES": return MerchantBusinessType.SchoolsAndEducationalServices;
                case "SPORTING_GOODS": return MerchantBusinessType.SportingGoods;
                case "TAXICABS_AND_LIMOUSINES": return MerchantBusinessType.TaxicabsAndLimousines;
                case "TICKET_SALES": return MerchantBusinessType.TicketSales;
                case "TOURISM": return MerchantBusinessType.Tourism;
                case "TRAVEL_TOURISM": return MerchantBusinessType.TravelTourism;
                case "VETERINARY_SERVICES": return MerchantBusinessType.VeterinaryServices;
                case "WEB_DEV_DESIGN": return MerchantBusinessType.WebDevDesign;
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}