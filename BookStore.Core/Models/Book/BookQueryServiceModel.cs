using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Models.Book
{
    public class BookQueryServiceModel
    {
        public int TotalBooksCount { get; set; }
        public IEnumerable<BookCardViewModel> Books { get; set; } = new List<BookCardViewModel>();
    }
}
