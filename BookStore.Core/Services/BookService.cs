﻿using BookStore.Core.Contracts;
using BookStore.Core.Enums;
using BookStore.Core.Models.Book;
using BookStore.Infrastructure.Data.Common;
using BookStore.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Services
{
    public class BookService :IBookService
    {
        private readonly IRepository repository;
        public BookService(IRepository _repository)
        {
            repository = _repository;           
        }

		public async Task<BookQueryServiceModel> AllAsync(string? genre = null, string? searchTerm = null, BookSorting sorting = BookSorting.Alphabetical, int currentPage = 1, int booksPerPage = 16, bool approved=true, int? userId = null)
		{
			var booksToShow = repository.AllReadOnly<Book>().Where(h=>h.IsApproved == approved);
			
			if (string.IsNullOrEmpty(genre) == false)
			{
                var genreOfBook = await repository.AllReadOnly<Genre>().FirstOrDefaultAsync(g => g.Name == genre) ?? throw new NullReferenceException("Genre with this id does not exist"); ;
                booksToShow = booksToShow.Where(b => b.GenreId == genreOfBook.Id);
			}
			if (userId != null)
			{
				booksToShow = booksToShow.Where(b => b.ClientId == userId);
			}

			if (string.IsNullOrEmpty(searchTerm) == false)
			{
				string normalisedSearchTerm = searchTerm.ToLower();
				booksToShow = booksToShow
					.Where(b => (b.Title.ToLower().Contains(normalisedSearchTerm) ||
								b.Description.ToLower().Contains(normalisedSearchTerm) ||
								b.AuthorName.ToLower().Contains(normalisedSearchTerm) ||
								b.Genre.Name.ToLower().Contains(normalisedSearchTerm)));
			}

			booksToShow = sorting switch
			{
				BookSorting.Alphabetical => booksToShow
					.OrderBy(b => b.Title)
					.ThenBy(b=>b.Id),
				BookSorting.Price => booksToShow
					.OrderBy(b => b.Price)
					.ThenByDescending(h => h.Id),
				BookSorting.InStock => booksToShow
				.OrderBy(b=>b.InStock==true)
				.ThenBy(b=>b.Title),
				BookSorting.Rating => booksToShow
					.OrderByDescending (b=>b.Rating)
					.ThenBy (b=>b.Title),
					_ => booksToShow.OrderBy(b=>b.Title)
			};

			var books = await booksToShow
				.Skip((currentPage - 1) * booksPerPage)
				.Take(booksPerPage)
				.ProjectToBookCardViewModel()
				.ToListAsync();
			int totalBooks = await booksToShow.CountAsync();
			return new BookQueryServiceModel()
			{
				Books = books,
				TotalBooksCount = totalBooks
			};
		}

		public async Task<IEnumerable<BookGenreServiceModel>> AllGenresAsync()
		{
			return await repository.AllReadOnly<Genre>()
				.Select(g=> new BookGenreServiceModel()
				{
					Id = g.Id,
					Name = g.Name
				}).ToListAsync();
		}

		public async Task<IEnumerable<string>> AllGenresNamesAsync()
		{
			return await repository.AllReadOnly<Genre>()
				.Select(g => g.Name)
				.ToListAsync();
		}

		public async Task<BookDetailsViewModel> BookDetailsByIdAsync(int id)
		{
			var bookById = await repository.GetByIdAsync<Book>(id) ?? throw new NullReferenceException("Book does not exist with this id");
            bookById.Genre = await repository.GetByIdAsync<Genre>(bookById.GenreId)?? throw new NullReferenceException("Book does not exist");

            return new BookDetailsViewModel
			{
				Author = bookById.AuthorName,
				Description = bookById.Description,
				GenreName = bookById.Genre.Name,
				Id = bookById.Id,
				ImageUrl = bookById.ImageUrl,
				InStock = bookById.InStock,
				Price = bookById.Price,
				Rating = bookById.Rating,
				Title = bookById.Title,
				IsApproved = bookById.IsApproved,
			};
			
		}

		public async Task<bool> GenreExistsAsync(int genreId)
		{
			Genre? genre = await repository.GetByIdAsync<Genre>(genreId);
			return genre!=null;
		}

		public async Task<int> CreateAsync(BookFormModel model, int clientId)
		{
            Book book = new Book()
			{
				AuthorName = model.AuthorName,
				Description = model.Description,
				GenreId = model.GenreId,
				ImageUrl = model.ImageUrl,
				InStock = true,
				Price = model.Price,
				Rating = model.Rating,
				Title = model.Title,
				ClientId = clientId
			};

            await repository.AddAsync<Book>(book);
			await repository.SaveChangesAsync();
			return book.Id;

		}

		public async Task DeleteAsync(int bookId)
		{
            await repository.DeleteAsync<Book>(bookId);
            await repository.SaveChangesAsync();
        }

		public async Task<bool> BookExistsByIdAsync(int id)
		{
			return (await repository.GetByIdAsync<Book>(id)) != null;
		}

        public async Task<int?> GetGenreIdByNameAsync(string genreName)
        {
			var genre = await repository.AllReadOnly<Genre>().FirstOrDefaultAsync(g => g.Name == genreName);
			return genre?.Id;
        }

        public async Task<IEnumerable<Book>> AllBookBooksAsync()
        {
            return await repository.AllReadOnly<Book>().ToListAsync();
        }

        public async Task ApproveBookAsync(int id)
        {
			Book? book = await repository.GetByIdAsync<Book>(id);
			book.IsApproved = true;
			await repository.SaveChangesAsync();
        }
    }
}
