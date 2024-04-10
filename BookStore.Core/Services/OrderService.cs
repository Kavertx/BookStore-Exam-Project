using BookStore.Core.Contracts;
using BookStore.Core.Models.Book;
using BookStore.Core.Models.Order;
using BookStore.Infrastructure.Data.Common;
using BookStore.Infrastructure.Data.Models;
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

        public async Task<ICollection<OrderItemModel>> AllClientOrdersAsync(string userId)
        {
            var clientId = await clientService.GetClientIdAsync(userId);
            return await repository.AllReadOnly<Order>().Where(o=>o.BuyerId ==clientId)
                .Select(o=> new OrderItemModel()
                {
                    Id = o.Id,
                    TimeOfOrder = o.TimeOfOrder,
                    TotalPrice = o.TotalPrice,
                })
                .ToListAsync();   
        }

        public async Task<int> CreateAsync(List<Book> books, int clientId, DateTime dateTime, decimal totalPrice)
        {
            await repository.AddAsync<Order>(new Order()
            {
                Books = books.AsQueryable().AsNoTracking().ToList(),
                BuyerId = clientId,
                TimeOfOrder = dateTime,
                TotalPrice = totalPrice
            });
            return await repository.SaveChangesAsync();
        }

        public async Task<OrderViewModel> GetOrderByIdAsync(int orderId)
        {
            var order = await repository.GetByIdAsync<Order>(orderId);
            if (order == null)
            {
                throw new ArgumentException("No such order exists", "getorderbyid");
            }
            var orderVM = new OrderViewModel()
            {
                Id = order.Id,
                TimeOfOrder = order.TimeOfOrder,
                TotalPrice = order.TotalPrice,
                Books = order.Books.Select(b => new BookInOrderViewModel()
                {
                    Author = b.AuthorName,
                    Price = b.Price,
                    Title = b.Title,
                }).ToList()
            };
            return orderVM;

        }
    }
}
