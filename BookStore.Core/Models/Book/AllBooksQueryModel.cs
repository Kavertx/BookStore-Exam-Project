using BookStore.Core.Enums;
using BookStore.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Models.Book
{
    public class AllBooksQueryModel
    {
        public int BooksPerPage { get; } = 16;
        public string? GenreName { get; set; } = null;
        public string SearchTerm { get; set; } = string.Empty;
        public BookSorting Sorting { get; set; } = 0;
        public int CurrentPage { get; set; } = 1;
        public int TotalBooksCount { get; set; }
        public IEnumerable<BookCardViewModel> Books { get; set; } = new List<BookCardViewModel>();  
    }
}
