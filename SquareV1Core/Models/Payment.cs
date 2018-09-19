using System;
using System.Collections.Generic;

namespace Meyer.Square.V1.Models
{
    public class Payment
    {
        public string Id { get; set; }
        public string MerchantId { get; set; }
        public DateTime Created { get; set; }
        public string PaymentUrl { get; set; }
        public string ReceiptUrl { get; set; }
        public Money InclusiveTaxMoney { get; set; }
        public Money AdditiveTaxMoney { get; set; }
        public Money TaxMoney { get; set; }
        public Money TipMoney { get; set; }
        public Money DiscountMoney { get; set; }
        public Money TotalCollectedMoney { get; set; }
        public Money ProcessingFeeMoney { get; set; }
        public Money NetTotalMoney { get; set; }
        public Money refundedMoney { get; set; }
        public Money GroseSalesMoney { get; set; }
        public Money NetSalesMoney { get; set; }
        public Money SurchargeMoney { get; set; }
        public IEnumerable<object> Surcharges { get; set; }
        public IEnumerable<object> InclusiveTax { get; set; }
        public IEnumerable<Tax> AdditiveTax { get; set; }
        public IEnumerable<Tender> Tender { get; set; }
        public IEnumerable<Refund> Refunds { get; set; }
        public IEnumerable<Itemization> Itemizations { get; set; }
    }
}
