using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BOOKSHOP.Models.DTOs.CustomerDTOs
{
    public class CustomerDTO
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string ProfilePics { get; set; }

    }
}
