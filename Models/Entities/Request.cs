namespace BOOKSHOP.Models.Entities
{
    public class Request : BaseEntity
    {
        public string RefNo { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Author { get; set; }
        public string AuthorStatement { get; set; }
        public string DateOfPub { get; set; }
        public string ISBN { get; set; }
        public string RequestMaker { get; set; }
        public string PhoneNumber { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
