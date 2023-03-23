using BOOKSHOP.Models.DTOs.CustomerDTOs;
using BOOKSHOP.Models.Entities;

namespace BOOKSHOP.Services.Interface
{
    public interface ICustomerService
    {
        Task<Customer> CreateCustomer(CreateCustomerRequestModel customer);
        void Delete(Customer customer);
        Customer CustomerGetById(string customerId);
        Customer GetByEmail(string email);
        Task<List<Customer>> GetAllCustomer();
        Task<Customer> Update(UpdateCustomerRequestModel customer);
        Task<Customer> UpdatePassword(UpdateCustomerPasswordRequestModel customer);
    }
}
