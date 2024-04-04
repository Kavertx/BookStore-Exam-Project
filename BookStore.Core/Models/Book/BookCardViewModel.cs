using BookStore.Core.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookStore.Infrastructure.Constants.DataConstants;

namespace BookStore.Core.Models.Book
{
    public class BookCardViewModel
    {
        public int Id { get; set; }
        [StringLength(BookConstants.TitleMax, MinimumLength = BookConstants.TitleMin)]
        public string Title { get; set; } = string.Empty;
        [StringLength(BookConstants.AuthorNameMax, MinimumLength = BookConstants.AuthorNameMin)]
        public string Author { get; set; } = string.Empty;
        [Required]
        public string ImageUrl { get; set; } = string.Empty;
        public decimal Rating { get; set; }
        [Display(Name = "Currently in stock")]
        public bool InStock { get; set; }
        public decimal Price { get; set; }

    }
}
