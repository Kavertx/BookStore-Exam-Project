using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Models.Order
{
	public class OrderItemModel
	{
		public int Id { get; set; }
		public decimal TotalPrice { get; set; }
		public DateTime TimeOfOrder { get; set; }
	}
}
