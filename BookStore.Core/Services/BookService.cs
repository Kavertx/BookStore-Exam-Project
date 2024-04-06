using BookStore.Core.Contracts;
using BookStore.Core.Enums;
using BookStore.Core.Models.Book;
using BookStore.Infrastructure.Data.Common;
using BookStore.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
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

		public async Task<BookQueryServiceModel> AllAsync(string? genre = null, string? searchTerm = null, BookSorting sorting = BookSorting.Alphabetical, int currentPage = 1, int booksPerPage = 16)
		{
			var booksToShow = repository.AllReadOnly<Book>();
			
			if (string.IsNullOrEmpty(genre) == false)
			{
                var genreOfBook = await repository.AllReadOnly<Genre>().FirstOrDefaultAsync(g => g.Name == genre);
                booksToShow = booksToShow.Where(b => b.GenreId == genreOfBook.Id);
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
			var bookById = await repository.GetByIdAsync<Book>(id);
			bookById.Genre = await repository.GetByIdAsync<Genre>(bookById.GenreId)?? null;

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
				
			};
			
		}

		public async Task<bool> GenreExistsAsync(int genreId)
		{
			Genre? genre = await repository.GetByIdAsync<Genre>(genreId);
			return genre!=null;
		}

		public Task<int> CreateAsync(BookFormModel model)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(int bookId)
		{
			throw new NotImplementedException();
		}

		public Task EditAsync(int houseId, BookFormModel model)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> BookExistsByIdAsync(int id)
		{
			return (await repository.GetByIdAsync<Book>(id)) != null;
		}

		public Task<BookFormModel?> GetBookFormModelByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<BookCardViewModel>> GetBooksByGenreAsync(int genreId)
		{
			return await repository.AllReadOnly<Book>()
				.Where(b=>b.GenreId == genreId)
				.Select(b=> new BookCardViewModel()
				{
					Author = b.AuthorName,
					Id = b.Id,
					ImageUrl = b.ImageUrl,
					InStock = b.InStock,
					Rating = b.Rating,
					Title = b.Title,
				}).ToListAsync();
		}

        public async Task<string> GetGenreNameByIdAsync(int genreId)
        {
			var genre = await repository.GetByIdAsync<Genre>(genreId);
            return genre.Name;
        }
    }
}
