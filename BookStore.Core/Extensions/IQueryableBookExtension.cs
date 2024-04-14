using BookStore.Core.Models.Book;
using BookStore.Core.Models.Review;
using BookStore.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Linq;

public static class IQueryableBookExtension
{
	public static IQueryable<BookCardViewModel> ProjectToBookCardViewModel(this IQueryable<Book> books)
	{
		return books
			.Select(b => new BookCardViewModel()
			{
				Id = b.Id,
				Author = b.AuthorName,
				ImageUrl = b.ImageUrl,
				InStock = b.InStock,
				Rating = b.Rating,
				Title = b.Title,
				Price = b.Price,
			});
	}
    public static IQueryable<ReviewCardModel> ProjectToReviewCardViewModel(this IQueryable<Review> reviews)
    {
        return reviews
            .Select(r => new ReviewCardModel()
            {
                Id = r.Id,
                Author = r.Book.AuthorName,
                ImageUrl = r.Book.ImageUrl,
                Title = r.Book.Title,
                ReviewContent = r.ReviewContent,
				BookId = r.BookId
            });
    }
}
