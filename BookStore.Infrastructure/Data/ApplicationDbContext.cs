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
            builder.ApplyConfiguration(new GenreConfig());
            builder.ApplyConfiguration(new BookConfig());
			base.OnModelCreating(builder);
		}
		public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;

    }
}
