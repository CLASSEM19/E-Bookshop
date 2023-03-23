using BOOKSHOP.Models.Entities;

namespace BOOKSHOP.Repository.Interface
{
    public interface ICartReository
    {
        Task<Cart> CreateAsync(Cart cart);
        void Delete(Cart cart);
        Task<List<Cart>> GetAllCartAsync(); 
        Cart GetCartById(string cartId);
    }
}
