﻿namespace BOOKSHOP.Models.DTOs.CustomerDTOs
{
    public class UpdateCustomerRequestModel
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePics { get; set; }
    }
}
