using BookStore.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Models.Order
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public DateTime TimeOfOrder { get; set; }
        public ICollection<BookInOrderViewModel> Books { get; set; } = null!;
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        public int BooksOrdered {  get; set; }
    }
}
