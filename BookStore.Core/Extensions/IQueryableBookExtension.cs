﻿using BookStore.Core.Models.Book;
using BookStore.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Linq;

public static class IQueryableBookExtension
{
	public static IQueryable<BookCardViewModel> ProjectToBookCardViewModel(this IQueryable<BookStore.Infrastructure.Data.Models.Book> books)
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
}