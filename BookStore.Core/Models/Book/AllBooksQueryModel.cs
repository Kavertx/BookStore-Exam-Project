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
        public int BooksPerPage { get; } = 15;
        public string Genre { get; set; }
        public string SearchTerm { get; set; }
        public BookSorting Sorting { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int TotalBooksCount { get; set; }
        public  IEnumerable<BookGenreServiceModel> Genres { get; set; }
        public BookQueryServiceModel Books { get; set; } 
    }
}
