namespace BOOKSHOP.Models.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public GenderType Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string ProfilePics { get; set; }
        public Role Role { get; set; }
        public Admin Admin { get; set; }
        public Customer Customer { get; set; }
        public ICollection<UserBook> UserBooks { get; set; }
    }
}
