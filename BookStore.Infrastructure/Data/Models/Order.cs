using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Infrastructure.Data.Models
{
    public class Order
    {
        //maybe having GUID as Id would make more sense here
        [Key]
        public int Id { get; set; }
        [Required]
        public int BuyerId { get; set; }
        [ForeignKey(nameof(BuyerId))]
        public Client Buyer { get; set; } = null!;
        [Required]
        public DateTime TimeOfOrder { get; set; } = DateTime.Now;
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        [Required]
        public int NumberOfBooks { get; set; }
        public ICollection<BookOrder> BooksOrders { get; set; } = new List<BookOrder>();
    }
}
