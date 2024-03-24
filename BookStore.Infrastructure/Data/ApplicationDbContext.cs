using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookStore.Infrastructure.Data.Models;

namespace BookStore.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

    }
}
