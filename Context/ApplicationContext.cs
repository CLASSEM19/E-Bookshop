
using BOOKSHOP.Models.Entities;
using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Author> Authorities { get; set; }
    public DbSet<Book> Books { get; set; }
    
}
