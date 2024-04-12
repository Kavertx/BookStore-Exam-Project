using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookStore.Infrastructure.Data.Models;
using BookStore.Infrastructure.Data.Seed;

namespace BookStore.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
		protected override void OnModelCreating(ModelBuilder builder)
		{
            base.OnModelCreating(builder);
            builder.Entity<BookOrder>(e=>e.HasKey(k=> new {k.OrderId, k.BookId}));
            builder.ApplyConfiguration(new UserConfig());
            builder.ApplyConfiguration(new GenreConfig());
            builder.ApplyConfiguration(new BookConfig());
        }
		public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<BookOrder> BooksOrders { get; set; } = null!;

    }
}
