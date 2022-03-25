namespace DiscountApp.Api.Model
{
    public class DiscountDetail
    {
        public decimal DiscountRatio { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPriceDiscount { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal PayableTotalPrice { get; set; }
    }
}
