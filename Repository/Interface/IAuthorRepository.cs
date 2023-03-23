using BOOKSHOP.Models.Entities;

namespace BOOKSHOP.Repository.Interface
{
    public interface IAuthorRepository 
    {
        Task<Author> CreateAsync(Author author);    
        Task<Author> UpdateAsync(Author author);
        Author AuthorGetById(string authorId);
        Author AuthorGetByName(string authorName);
        Task<List<Author>> GetAllAuthor();
    }
}
