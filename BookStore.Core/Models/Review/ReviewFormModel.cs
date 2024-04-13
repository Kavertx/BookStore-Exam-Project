using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookStore.Infrastructure.Constants.DataConstants;

namespace BookStore.Core.Models.Review
{
    public class ReviewFormModel
    {
        [Required]
        public int BookId { get; set; }
        [Required]
        [StringLength(ReviewConstants.ReviewContentMax, MinimumLength = ReviewConstants.ReviewContentMin)]
        public string ReviewContent { get; set; } = string.Empty;
        [Required]
        [StringLength(BookConstants.TitleMax, MinimumLength =BookConstants.TitleMin)]
        public string BookTitle { get; set; } = string.Empty;
        [Required]
        [StringLength(BookConstants.AuthorNameMax, MinimumLength = BookConstants.AuthorNameMin)]
        public string AuthorName { get; set; } = string.Empty;
        [Required]
        public string ImageUrl { get; set; } = string.Empty;

    }
}
