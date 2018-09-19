using System.Collections.Generic;

namespace Meyer.Square.V1.Models
{
    public class Itemization
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string Notes { get; set; }
        public ItemDetail ItemDetail { get; set; }
        public ItemizationType Type { get; set; }
        public Money TotalMoney { get; set; }
        public Money SingleQuantityMoney { get; set; }
        public Money GrossSalesMoney { get; set; }
        public Money DiscountMoney { get; set; }
        public Money NetSalesMoney { get; set; }
        public IEnumerable<Tax> Taxes { get; set; }
        public IEnumerable<Discount> Discounts { get; set; }
        public IEnumerable<Modifier> Modifiers { get; set; }
    }
}