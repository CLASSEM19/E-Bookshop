namespace BOOKSHOP.Models.Entities
{
    public class AuthorBook : BaseEntity 
    {
        public DateTime PublicationDate { get; set; }
        public string AuthorId { get; set; }
        public Author Author { get; set; }
        public string BookId { get; set; }
        public Book Book { get; set; }
    }
}
