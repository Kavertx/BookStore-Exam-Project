using BookStore.Core.Enums;
using BookStore.Core.Models.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Contracts
{
    public interface IBookService
    {

		Task<IEnumerable<BookGenreServiceModel>> AllGenresAsync();

		Task<bool> GenreExistsAsync(int genreId);

		Task<int> CreateAsync(BookFormModel model);

		Task<BookQueryServiceModel> AllAsync(string? genre = null, string? searchTerm = null, BookSorting sorting = BookSorting.Alphabetical, int currentPage = 1, int booksPerPage = 15);

		Task<IEnumerable<string>> AllGenresNamesAsync();
		Task<string> GetGenreNameByIdAsync(int genreId);

		Task<bool> BookExistsByIdAsync(int id);
		Task<BookDetailsViewModel> BookDetailsByIdAsync(int id);
		Task<IEnumerable<BookCardViewModel>> GetBooksByGenreAsync(int genreId);
		Task DeleteAsync(int bookId);
		Task <int?> GetGenreIdByNameAsync(string genreName);
	}
}
