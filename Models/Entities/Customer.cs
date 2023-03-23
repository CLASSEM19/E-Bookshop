namespace BOOKSHOP.Models.Entities
{
    public class Customer : BaseEntity
    {
        public string RegNo { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Request> Requests { get; set; }
    }
}
