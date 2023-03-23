namespace BOOKSHOP.Models.Entities
{
    public class UserBook
    {
        public DateTime PublicationDate { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string BookId { get; set; }
        public Book Book { get; set; }
    }
}
