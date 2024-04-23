using BookStore.Core.Enums;
using BookStore.Core.Models.Book;
using BookStore.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Contracts
{
    public interface IBookService
    {
		Task<IEnumerable<Book>> AllBookBooksAsync();
		Task<IEnumerable<BookGenreServiceModel>> AllGenresAsync();

		Task<bool> GenreExistsAsync(int genreId);

		Task<int> CreateAsync(BookFormModel model, int clientId);

		Task<BookQueryServiceModel> AllAsync(string? genre = null, string? searchTerm = null, BookSorting sorting = BookSorting.Alphabetical, int currentPage = 1, int booksPerPage = 15, bool approved=true);

		Task<IEnumerable<string>> AllGenresNamesAsync();
		Task<string> GetGenreNameByIdAsync(int genreId);

		Task<bool> BookExistsByIdAsync(int id);
		Task<BookDetailsViewModel> BookDetailsByIdAsync(int id);
		Task<IEnumerable<BookCardViewModel>> GetBooksByGenreAsync(int genreId);
		Task DeleteAsync(int bookId);
		Task <int?> GetGenreIdByNameAsync(string genreName);

		Task ApproveBookAsync(int id);
	}
}
