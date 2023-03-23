namespace BOOKSHOP.Models.Entities
{
    public class Payment : BaseEntity
    {
        public string RefNo { get; set; }
        public string BookId { get; set; }
        public decimal Amount { get; set; }
        public Customer Customer { get; set; }
        public Book Book { get; set; }
        public string CartId { get; set; }
        public Cart Cart { get; set; }
        public string OrderId { get; set; }
        public Order Order { get; set; }
    }
}
