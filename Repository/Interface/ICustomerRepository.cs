using BOOKSHOP.Models.Entities;

namespace BOOKSHOP.Repository.Interface
{
    public interface ICustomerRepository
    {
       Task<Customer> Create(Customer customer);
        void Delete(Customer customer);
        Customer CustomerGetById(string customerId);
        Customer GetByEmail(string email);
        Task<List<Customer>> GetAllCustomer();
        Task<Customer> Update(Customer customer);
        Task<Customer> UpdatePassword(Customer customer);
    }
}
