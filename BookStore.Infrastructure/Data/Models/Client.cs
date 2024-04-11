using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Infrastructure.Data.Models
{
    public class Client
    {
        //should add Username upon registration for reviews later I think
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Book> MyBooks { get; set; } = new List<Book>();
        public ICollection<Book> FavouriteBooks { get; set; } =new List<Book>();
    }
}
