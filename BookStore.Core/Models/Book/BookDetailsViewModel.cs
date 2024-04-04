using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookStore.Infrastructure.Constants.DataConstants;

namespace BookStore.Core.Models.Book
{
    public class BookDetailsViewModel
    {
        public int Id { get; set; }
        [StringLength(BookConstants.TitleMax, MinimumLength = BookConstants.TitleMin)]
        public string Title { get; set; } = string.Empty;
        [StringLength(BookConstants.DescriptionMax, MinimumLength = BookConstants.DescriptionMin)]
        public string Description { get; set; } = string.Empty;
        [StringLength(BookConstants.AuthorNameMax, MinimumLength = BookConstants.AuthorNameMin)]
        public string Author { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public decimal Rating { get; set; }
        public string GenreName { get; set; } = string.Empty;
        public bool InStock { get; set; }
        public decimal Price { get; set; }
    }
}
