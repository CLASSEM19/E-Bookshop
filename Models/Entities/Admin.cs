namespace BOOKSHOP.Models.Entities
{
    public class Admin : BaseEntity
    {
        public string RegNo { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
