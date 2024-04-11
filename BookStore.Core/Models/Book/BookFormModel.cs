using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookStore.Infrastructure.Constants.DataConstants;

namespace BookStore.Core.Models.Book
{
    public class BookFormModel
    {
        [Required]
        [StringLength(BookConstants.TitleMax, MinimumLength = BookConstants.TitleMin)]
        public string Title { get; set; } = null!;
        [Required]
        [StringLength(BookConstants.AuthorNameMax, MinimumLength = BookConstants.AuthorNameMin)]
        public string AuthorName { get; set; } = null!;
        [Required]
        [StringLength(BookConstants.DescriptionMax, MinimumLength = BookConstants.DescriptionMin)]
        public string Description { get; set; } = null!;
        [Required]
        [Range(typeof(decimal), BookConstants.PriceMin,BookConstants.PriceMax, ConvertValueInInvariantCulture = true)]
        public decimal Price { get; set; }
        [Required]
        [Range(BookConstants.RatingMin, BookConstants.RatingMax)]
        public int Rating { get; set; }
        [Required]
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; } = null!;
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        public IEnumerable<BookGenreServiceModel> Genres { get; set; } = new List<BookGenreServiceModel>();

    }
}
