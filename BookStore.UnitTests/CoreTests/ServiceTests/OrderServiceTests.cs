using BookStore.Core.Contracts;
using BookStore.Core.Models.Order;
using BookStore.Core.Services;
using BookStore.Infrastructure.Data.Common;
using BookStore.Infrastructure.Data;
using BookStore.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.UnitTests.CoreTests.ServiceTests
{
    [TestFixture]
    public class OrderServiceTests
    {

        private ApplicationDbContext context;
        private IRepository repository;
        private IBookService bookService;
        private IOrderService orderService;
        private IClientService clientService;
        private string testUserId = "5c35b64b-b218-4548-ba50-5b75879a422f";
        [SetUp]
        public async Task Setup()
        {

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryDb")
                .Options;
            context = new ApplicationDbContext(options);
            var books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "Book A",
                    AuthorName = "Test1",
                    ClientId =1,
                    IsApproved=true,
                    Description = "Test DescriptionTest DescriptionTest DescriptionTest DescriptionTest Description",
                    GenreId = 1,
                    ImageUrl = "test",
                    InStock = true,
                    Price = 10,
                    Rating = 5
                },
                new Book
                {
                    Id = 2,
                    Title = "Book B",
                    AuthorName = "Test2",
                    ClientId =1,
                    IsApproved=true,
                    Description = "Test DescriptionTest DescriptionTest DescriptionTest DescriptionTest Description",
                    GenreId = 2,
                    ImageUrl = "test",
                    InStock = true,
                    Price = 10,
                    Rating = 5
                },
                new Book
                {
                    Id = 3,
                    Title = "Book C",
                    AuthorName = "Test3",
                    ClientId =1,
                    IsApproved=true,
                    Description = "Test DescriptionTest DescriptionTest DescriptionTest DescriptionTest Description",
                    GenreId = 3,
                    ImageUrl = "test",
                    InStock = true,
                    Price = 10,
                    Rating = 5
                }
            };
            var genres = new List<Genre>
            {
                new Genre
                {
                    Id= 1,
                    Name = "Genre A"
                },
                new Genre
                {
                    Id= 2,
                    Name = "Genre B"
                },
                new Genre
                {
                    Id= 3,
                    Name = "Genre C"
                }
            };
            var client = new Client
            {
                Id = 1,
                UserId = testUserId,
                UserName = "Test Client",
            };
            var order = new Order
            {
                BuyerId = client.Id,
                Id = 1,
                NumberOfBooks = 2,
                TimeOfOrder = DateTime.Now,
                TotalPrice = 20
            };
            await context.Books.AddRangeAsync(books);
            await context.Genres.AddRangeAsync(genres);
            await context.Clients.AddAsync(client);
            await context.Orders.AddAsync(order);
            await context.SaveChangesAsync();
            repository = new Repository(context);
            bookService = new BookService(repository);
            clientService = new ClientService(repository);
            orderService = new OrderService(repository, clientService);
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.Database.EnsureDeletedAsync();
            await context.DisposeAsync();
        }



        [Test]
        public async Task AllClientOrdersAsync()
        {
           var allUserOrders = await orderService.AllClientOrdersAsync(testUserId);
            Assert.That(allUserOrders!=null);
            Assert.That(allUserOrders.Any());
            Assert.That(allUserOrders.Count, Is.EqualTo(1));

        }
        [Test]
        public async Task GetOrderByIdAsync()
        {
            var orderId = 1;
            var order = await repository.GetByIdAsync<Order>(orderId);
            Assert.That((await orderService.GetOrderByIdAsync(orderId)) != null);
            Assert.That((await orderService.GetOrderByIdAsync(orderId)) ==order);
        }
        [Test]
        public async Task CreateAsync()
        {
            var order = new Order
            {
                BuyerId = 1,
                Id = 2,
                NumberOfBooks = 3,
                TimeOfOrder = DateTime.Now,
                TotalPrice = 30
            };
            var books = await repository.AllReadOnly<Book>().ToListAsync();
            var totalOrdersBefore = (await repository.AllReadOnly<Order>().ToListAsync()).Count();
            await orderService.CreateAsync(order.BuyerId, order.TimeOfOrder, order.TotalPrice, order.NumberOfBooks, books);
            var totalOrdersAfter = (await repository.AllReadOnly<Order>().ToListAsync()).Count();
            Assert.That((await repository.GetByIdAsync<Order>(2)) != null);
            Assert.That(totalOrdersBefore != totalOrdersAfter);

        }
        [Test]
        public async Task GetBooksFromOrderIdAsync()
        {
            var order = new Order
            {
                BuyerId = 1,
                Id = 2,
                NumberOfBooks = 3,
                TimeOfOrder = DateTime.Now,
                TotalPrice = 30
            };
            var books = await repository.AllReadOnly<Book>().ToListAsync();
            await orderService.CreateAsync(order.BuyerId, order.TimeOfOrder, order.TotalPrice, order.NumberOfBooks, books);
            var orderFromDb = (await repository.GetByIdAsync<Order>(order.Id));

            var booksFromOrder = (await orderService.GetBooksFromOrderIdAsync(order.Id));
            Assert.That(booksFromOrder!= null);
            Assert.That(orderFromDb.BooksOrders.Count() == books.Count());
            Assert.That((await orderService.GetBooksFromOrderIdAsync(order.Id)).Count()==books.Count());

        }
        [Test]
        public async Task GetLastClientOrderAsync()
        {
            var order = new Order
            {
                BuyerId = 1,
                Id = 2,
                NumberOfBooks = 3,
                TimeOfOrder = DateTime.Now,
                TotalPrice = 30
            };
            var books = await repository.AllReadOnly<Book>().ToListAsync();
            await orderService.CreateAsync(order.BuyerId, order.TimeOfOrder, order.TotalPrice, order.NumberOfBooks, books);

            var order2 = (await repository.GetByIdAsync<Order>(order.Id));
            var lastClientOrder = (await orderService.GetLastClientOrderAsync(1));
            Assert.That(lastClientOrder!= null);
            Assert.That(lastClientOrder.Id == order2.Id);

        }
    }
}
