using BOOKSHOP.Models.Entities;
using BOOKSHOP.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BOOKSHOP.Repository.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationContext _context;
        public CustomerRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Customer> Create(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return customer;

        }

        public Customer CustomerGetById(string customerId)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == customerId);
            return customer;
        }

        public void Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public async Task<List<Customer>> GetAllCustomer()
        {
            var customer = await _context.Customers.Where(w => !w.IsDeleted && w.IsActive).ToListAsync();
            return customer;
        }

        public Customer GetByEmail(string email)
        {
            var customer = _context.Customers.Include(w => w.User).FirstOrDefault(w => w.User.Email == email);
            return customer;
        }

        public async Task<Customer> Update(Customer customer)
        {
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> UpdatePassword(Customer customer)
        {
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
            return customer;
        }
    }
}
