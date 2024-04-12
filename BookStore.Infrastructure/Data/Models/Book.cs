using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BookStore.Infrastructure.Constants.DataConstants;

namespace BookStore.Infrastructure.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(BookConstants.TitleMax)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(BookConstants.DescriptionMax)]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Required]
        [MaxLength(BookConstants.AuthorNameMax)]
        public string AuthorName { get; set; } = string.Empty;
        [Required]
        public int GenreId { get; set; }
        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; } = null!;
        [Required]
        public bool InStock { get; set; }

        public string ImageUrl { get; set; } = string.Empty;
        [Range(BookConstants.RatingMin,BookConstants.RatingMax)]
        public int Rating { get; set; }
        public  ICollection<BookOrder> BooksOrders { get; set; } = new List<BookOrder>();
        
        public int ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; }
    }
}
