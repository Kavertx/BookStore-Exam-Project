using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Infrastructure.Data.Models
{
    public class Client
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Book> Books { get; set; } = new List<Book>();
        public ICollection<Book> FavouriteBooks { get; set; } =new List<Book>();
    }
}
