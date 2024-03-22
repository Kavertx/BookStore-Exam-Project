using System.ComponentModel.DataAnnotations;
using static BookStore.Infrastructure.Constants.DataConstants;

namespace BookStore.Infrastructure.Data.Models
{
    public class Genre
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(GenreConstants.NameMax)]
        public string Name { get; set; } = string.Empty;
    }
}
