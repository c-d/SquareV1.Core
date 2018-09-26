using System;

namespace MeyerCorp.Square.V1.Business
{
    /// <summary>
    /// Helper methods which make conversion of enum to and from string values required for HTTP/JSON more convenient.
    /// </summary>
    public static class EnumExtensions
    {
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


        public static string EnumToString(this CashDrawerEventType type)
        {
            switch (type)
            {
                case CashDrawerEventType.NoSale: return "NO_SALE";
                case CashDrawerEventType.CashTenderPayment: return "CASH_TENDER_PAYMENT";
                case CashDrawerEventType.OtherTenderPayment: return "OTHER_TENDER_PAYMENT";
                case CashDrawerEventType.CashTenderCanceledPayment: return "CASH_TENDER_CANCELED_PAYMENT";
                case CashDrawerEventType.OtherTenderCanceledPayment: return "OTHER_TENDER_CANCELED_PAYMENT";
                case CashDrawerEventType.CashTenderRefund: return "CASH_TENDER_REFUND";
                case CashDrawerEventType.OtherTenderRefund: return "OTHER_TENDER_REFUND";
                case CashDrawerEventType.PaidIn: return "PAID_IN";
                case CashDrawerEventType.PaidOut: return "PAID_OUT";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static CashDrawerEventType ToCashDrawerEventType(this string value)
        {
            switch (value)
            {
                case "NO_SALE": return CashDrawerEventType.NoSale;
                case "CASH_TENDER_PAYMENT": return CashDrawerEventType.CashTenderPayment;
                case "OTHER_TENDER_PAYMENT": return CashDrawerEventType.OtherTenderPayment;
                case "CASH_TENDER_CANCELED_PAYMENT": return CashDrawerEventType.CashTenderCanceledPayment;
                case "OTHER_TENDER_CANCELED_PAYMENT": return CashDrawerEventType.OtherTenderCanceledPayment;
                case "CASH_TENDER_REFUND": return CashDrawerEventType.CashTenderRefund;
                case "OTHER_TENDER_REFUND": return CashDrawerEventType.OtherTenderRefund;
                case "PAID_IN": return CashDrawerEventType.PaidIn;
                case "PAID_OUT": return CashDrawerEventType.PaidOut;
                default: throw new ArgumentOutOfRangeException();
            }
        }


        public static string EnumToString(this EmployeeRolePermissionType type)
        {
            switch (type)
            {
                case EmployeeRolePermissionType.RegisterAccessSalesHistory: return "REGISTER_ACCESS_SALES_HISTORY";
                case EmployeeRolePermissionType.RegisterApplyRestrictedDiscounts: return "REGISTER_APPLY_RESTRICTED_DISCOUNTS";
                case EmployeeRolePermissionType.RegisterChangeSettings: return "REGISTER_CHANGE_SETTINGS";
                case EmployeeRolePermissionType.RegisterEditItem: return "REGISTER_EDIT_ITEM";
                case EmployeeRolePermissionType.RegisterIssueRefunds: return "REGISTER_ISSUE_REFUNDS";
                case EmployeeRolePermissionType.RegisterOpenCashDrawerOutsideSale: return "REGISTER_OPEN_CASH_DRAWER_OUTSIDE_SALE";
                case EmployeeRolePermissionType.RegisterViewSummaryReports: return "REGISTER_VIEW_SUMMARY_REPORTS";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static EmployeeRolePermissionType ToEmployeeRolePermissionType(this string value)
        {
            switch (value)
            {
                case "REGISTER_ACCESS_SALES_HISTORY": return EmployeeRolePermissionType.RegisterAccessSalesHistory;
                case "REGISTER_APPLY_RESTRICTED_DISCOUNTS": return EmployeeRolePermissionType.RegisterApplyRestrictedDiscounts;
                case "REGISTER_CHANGE_SETTINGS": return EmployeeRolePermissionType.RegisterChangeSettings;
                case "REGISTER_EDIT_ITEM": return EmployeeRolePermissionType.RegisterEditItem;
                case "REGISTER_ISSUE_REFUNDS": return EmployeeRolePermissionType.RegisterIssueRefunds;
                case "REGISTER_OPEN_CASH_DRAWER_OUTSIDE_SALE": return EmployeeRolePermissionType.RegisterOpenCashDrawerOutsideSale;
                case "REGISTER_VIEW_SUMMARY_REPORTS": return EmployeeRolePermissionType.RegisterViewSummaryReports;
                default: throw new ArgumentOutOfRangeException();
            }
        }


        public static string EnumToString(this EmployeeStatusType type)
        {
            switch (type)
            {
                case EmployeeStatusType.Active: return "ACTIVE";
                case EmployeeStatusType.Inactive: return "INACTIVE";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static EmployeeStatusType ToEmployeeStatusType(this string value)
        {
            switch (value)
            {
                case "ACTIVE": return EmployeeStatusType.Active;
                case "INACTIVE": return EmployeeStatusType.Inactive;
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}