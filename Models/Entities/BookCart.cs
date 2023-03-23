namespace BOOKSHOP.Models.Entities
{
    public class BookCart : BaseEntity
    {
        public DateTime PublicationDate { get; set; }
        public string CartId { get; set; }
        public Cart Cart { get; set; }
        public string BookId { get; set; }
        public Book Book { get; set; }
    }
}
