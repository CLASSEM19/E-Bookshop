namespace BOOKSHOP.Models.Entities
{
    public class Cart : BaseEntity
    {
        public string RefNo { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DatePaid { get; set; }
        public bool IsPaid { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }
        public ICollection<BookCart> BookCarts { get; set; }
    }
}
