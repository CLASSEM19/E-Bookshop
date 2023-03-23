namespace BOOKSHOP.Models.Entities
{
    public class CustomerOrder : BaseEntity
    {
        public DateTime PublicationDate { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string OrderId { get; set; }
        public Order Order { get; set; }
    }
}
