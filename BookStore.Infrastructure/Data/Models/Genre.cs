using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
