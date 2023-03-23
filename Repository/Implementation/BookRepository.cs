using BOOKSHOP.Models.Entities;
using BOOKSHOP.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BOOKSHOP.Repository.Implementation
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationContext _context;
        public BookRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Book BookGetByAuthor(string authorId)
        {
            var book = _context.Books.SingleOrDefault(x => x.Id == authorId);
            return book;
        }

        public Book BookGetByName(string bookName)
        {
            var book = _context.Books.SingleOrDefault(x => x.Name == bookName);
            return book;
        }

        public Book BookGetById(string bookId)
        {
            var book = _context.Books.SingleOrDefault(x => x.Id == bookId);
            return book;
        }

        public async Task<Book> CreateAsync(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<List<Book>> GetAllBook()
        {
            var book = await _context.Books.Where(w => !w.IsDeleted && w.IsActive).ToListAsync();
            return book;
        }

        public async Task<Book> UpdateAsync(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
            return book;
        }
    }
}
