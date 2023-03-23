using BOOKSHOP.Models.Entities;
using BOOKSHOP.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BOOKSHOP.Repository.Implementation
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationContext _context;
        public AuthorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Author> CreateAsync(Author author)
        {
           await _context.Authorities.AddAsync(author);
            await _context.SaveChangesAsync();
            return author;
        }

        public async Task<List<Author>> GetAllAuthor()
        {
            var author = await _context.Authorities.Where(w => !w.IsDeleted && w.IsActive).ToListAsync();
            return author;
        }

        public Author AuthorGetById(string authorId)
        {
            var author =  _context.Authorities.SingleOrDefault(x => x.Id == authorId);
            return author;
        }

        public Author AuthorGetByName(string authorName)
        {
            var author = _context.Authorities.SingleOrDefault(x => x.Name == authorName);
            return author;
        }

        public async Task<Author> UpdateAsync(Author author)
        {
            _context.Authorities.Update(author);
            await _context.SaveChangesAsync();
            return author;
        }
    }
}
