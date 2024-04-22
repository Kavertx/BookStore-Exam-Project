using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public  string ReviewContent { get; set; } = string.Empty;
        [Required]
        public int ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; } = null!;
        [Required]
        public int BookId { get; set; }
        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; } = null!;
        [Required]
        public DateTime TimeOfReview { get; set; } = DateTime.Now;

        public bool IsApproved { get; set; } = false;
    }
}
