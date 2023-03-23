namespace BOOKSHOP.Models.Entities
{
    public class Order : BaseEntity
    {
        public string RefNumber { get; set; }
        public string CustomerName { get; set; }
        public string DeliveryAddress { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public string Goods { get; set; }
        public decimal TotalPrice { get; set; }
        public Payment Payment { get; set; }
    }
}
