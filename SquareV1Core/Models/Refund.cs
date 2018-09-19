using System;

namespace Meyer.Square.V1.Models
{
    public class Refund
    {
        public RefundType Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime Processed { get; set; }
        public string Reason { get; set; }
        public Money RefundedMoney { get; set; }
        public string PaymentId { get; set; }
        public string MerchantId { get; set; }
        public Money RefundedProcessingFeeMoney { get; set; }
        public object RefundedInclusiveTax { get; set; }
        public object RefundedAdditiveTax { get; set; }
        public object RefundedSurcharges { get; set; }
        public bool IsExchange { get; set; }
    }
}