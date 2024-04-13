using BookStore.Core.Contracts;
using BookStore.Core.Models.Book;
using BookStore.Core.Models.Order;
using BookStore.Infrastructure.Data.Common;
using BookStore.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Services
{
    public class OrderService :IOrderService
    {
        private readonly IRepository repository;
        private readonly IClientService clientService;
        public OrderService(IRepository _repository, IClientService _clientService)
        {
            repository = _repository;
            clientService = _clientService;
        }

        public async Task<ICollection<Order>> AllClientOrdersAsync(string userId)
        {
            var clientId = await clientService.GetClientIdAsync(userId);
             
            return await repository.AllReadOnly<Order>().Where(o => o.BuyerId == clientId).ToListAsync();
        }

        public async Task CreateAsync(int clientId, DateTime dateTime, decimal totalPrice, int numberOfBooks, List<Book> books)
        {

            var order = new Order()
            {
                BuyerId = clientId,
                TimeOfOrder = dateTime,
                TotalPrice = totalPrice,
                NumberOfBooks = numberOfBooks
            };
            foreach(var book in books)
            {
                BookOrder bo = new BookOrder()
                {
                    Order = order,
                    BookId = book.Id
                };
                order.BooksOrders.Add(bo);
            }
            await repository.AddAsync<Order>(order);
            await repository.SaveChangesAsync();
        }

        public Task CreateOrderAndAddToClientOrdersAsync(List<BookInOrderViewModel> books)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BookInOrderViewModel>> GetBooksFromOrderIdAsync(int orderId)
        {
            var bookIds = repository.AllReadOnly<BookOrder>().Where(bo => bo.OrderId == orderId).ToList();
            List<Book> books = new List<Book>();
            foreach (var book in bookIds)
            {
                Book bookToAdd = await repository.GetByIdAsync<Book>(book.BookId) ?? throw new NullReferenceException("Book with such Id doesn't exist");
                books.Add(bookToAdd);
            }
            var model = books.Select(b => new BookInOrderViewModel()
            {
                Author = b.AuthorName,
                Id = b.Id,
                ImageUrl = b.ImageUrl,
                Price = b.Price,
                Title = b.Title,
            });
            return model;
        }

        public async Task<Order> GetLastClientOrderAsync(int clientId)
        {
            var order = await repository.AllReadOnly<Order>().Where(o=> o.BuyerId==clientId).OrderByDescending(o=> o.Id).FirstOrDefaultAsync();
            return order;
        }

        public async Task<Order?> GetOrderByIdAsync(int orderId)
        {
            var order = await repository.GetByIdAsync<Order>(orderId);
            if (order == null)
            {
                throw new ArgumentException("No such order exists", "getorderbyid");
            }
            return order;

        }

        
    }
}
