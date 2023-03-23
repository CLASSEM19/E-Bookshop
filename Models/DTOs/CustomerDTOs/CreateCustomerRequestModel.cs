using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using BOOKSHOP.Enums;

namespace BOOKSHOP.Models.DTOs.CustomerDTOs
{
    public class CreateCustomerRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderType Gender { get; set; }
    }
}
