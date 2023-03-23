using BOOKSHOP.Models.Entities;

namespace BOOKSHOP.Repository.Interface
{
    public interface IBookRepository
    {
        Task<Book> CreateAsync(Book book);
        Task<Book> UpdateAsync(Book book);
        Book BookGetById(string bookId);
        Book BookGetByName(string bookName);
        Book BookGetByAuthor(string authorId);
        Task<List<Book>> GetAllBook();
    }
}
