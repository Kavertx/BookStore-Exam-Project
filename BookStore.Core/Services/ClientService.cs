using BookStore.Core.Contracts;
using BookStore.Core.Models.Book;
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
    public class ClientService :IClientService
    {
        private readonly IRepository repository;
        public ClientService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<BookQueryServiceModel> AllFavouriteBooksAsync(string userId)
        {
            var clientId = GetClientIdAsync(userId);
            var client = await repository.GetByIdAsync<Client>(clientId);
            ICollection<Book> clientFavouriteBooks = new List<Book>();
            if(client!=null)
            {
                clientFavouriteBooks = client.FavouriteBooks;
            }
            await clientFavouriteBooks.AsQueryable()
                .ProjectToBookCardViewModel()
                .ToListAsync();
            var result = new BookQueryServiceModel()
            {
                TotalBooksCount = clientFavouriteBooks.Count,
                Books = await clientFavouriteBooks.AsQueryable()
                .ProjectToBookCardViewModel()
                .ToListAsync()
            };
            return result;

        }

        public async Task<int?> GetClientIdAsync(string userId)
        {
            return (await repository.AllReadOnly<Client>()
                .FirstOrDefaultAsync(c => c.UserId == userId))?.Id; 
        }
    }
}
