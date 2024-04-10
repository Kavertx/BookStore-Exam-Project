using BookStore.Core.Models.Book;
using BookStore.Core.Models.Order;
using BookStore.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Contracts
{
    public interface IOrderService
    {
        Task<ICollection<OrderItemModel>> AllClientOrdersAsync(string userId);
        Task<OrderViewModel> GetOrderByIdAsync(int orderId);
        Task<int> CreateAsync(List<Book> books, int clientId, DateTime dateTime, decimal totalPrice);
    }
}
