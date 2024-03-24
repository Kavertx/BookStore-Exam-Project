using System.ComponentModel.DataAnnotations;
using static BookStore.Infrastructure.Constants.DataConstants;

namespace BookStore.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(CategoryConstants.NameMax)]
        public string Name { get; set; } = string.Empty;
        ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
