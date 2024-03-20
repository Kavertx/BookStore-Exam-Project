using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static BookStore.Infrastructure.Constants.DataConstants;

namespace BookStore.Infrastructure.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        // Is this supposed to be the AspNetUser Id or Client Id? 
        [Required]
        public int BuyerId { get; set; }
        [ForeignKey(nameof(BuyerId))]
        public Client Buyer { get; set; } = null!;
        [Required]
        public DateTime TimeOfOrder {  get; set; } = DateTime.Now;
        ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
