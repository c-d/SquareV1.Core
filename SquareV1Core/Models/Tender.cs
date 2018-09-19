namespace Meyer.Square.V1.Models
{
    public class Tender
    {
        public CreditCardType CreditCard { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public Money TotalMoney { get; set; }
        public CardBrandType CardBrand { get; set; }
        public string PanSuffix { get; set; }
        public EntryMethodType EntryMethod { get; set; }
        public Money RefundedMoney { get; set; }
        public string ReceiptUrl { get; set; }
        public string EmployeeId{ get; set; }
        public bool IsExchange { get; set; }
    }
}