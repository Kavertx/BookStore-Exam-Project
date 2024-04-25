using BookStore.Core.Contracts;
using BookStore.Core.Services;
using BookStore.Infrastructure.Data;
using BookStore.Infrastructure.Data.Common;
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
    public class ClientServiceTests
    {
        private ApplicationDbContext context;
        private IRepository repository;
        private IClientService clientService;
        private string testUserId = "5c35b64b-b218-4548-ba50-5b75879a422f";

        [SetUp]
        public async Task Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryDb")
                .Options;
            context = new ApplicationDbContext(options);
            var client = new Client
            {
                Id = 1,
                UserId = testUserId,
                UserName = "Test Client",
            };
            await context.Clients.AddAsync(client);
            await context.SaveChangesAsync();
            repository = new Repository(context);
            clientService = new ClientService(repository);

        }
        [TearDown]
        public async Task TearDown()
        {
            await context.Database.EnsureDeletedAsync();
            await context.DisposeAsync();
        }

        [Test]
        public async Task GetClientIdAsync()
        {
            var clientId = await clientService.GetClientIdAsync(testUserId);
            Assert.That(clientId !=default);
            Assert.That(clientId == 1);
        }
        [Test]
        public async Task GetClientByIdAsync()
        {
            var clientId = 1;
            var client = await clientService.GetClientByIdAsync(clientId);
            Assert.That(client!=null);
            Assert.That(client.UserId == testUserId);
            Assert.That(client.UserName == "Test Client");
        }
    }
}
