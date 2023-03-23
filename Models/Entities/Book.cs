namespace BOOKSHOP.Models.Entities
{
    public class Book : BaseEntity
    {
        public string RefNo { get; set; }
        public string Title { get; set; }
        public string DateOfPub { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public string AdminId { get; set; }
        public Admin Admin { get; set; }
        public ICollection<UserBook> UserBooks { get; set; }
        public ICollection<AuthorBook> AuthorBooks { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<BookCart> BookCarts { get; set; }
    }
}
