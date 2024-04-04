using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Models.Order
{
    public class BookInOrderViewModel
    {
        public string Title { get; set; } = string.Empty;
        public decimal Price { get; set; } 
        public string Author { get; set; } = string.Empty;
    }
}
