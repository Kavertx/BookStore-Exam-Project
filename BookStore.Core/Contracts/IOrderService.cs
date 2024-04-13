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
        Task<ICollection<Order>> AllClientOrdersAsync(string userId);
        Task<Order?> GetOrderByIdAsync(int orderId);
        Task CreateAsync(int clientId, DateTime dateTime, decimal totalPrice, int numberOfBooks, List<Book> books);
        Task<IEnumerable<BookInOrderViewModel>> GetBooksFromOrderIdAsync(int orderId);
        Task<Order> GetLastClientOrderAsync(int clientId);
        Task CreateOrderAndAddToClientOrdersAsync(List<BookInOrderViewModel> books);
    }
}
