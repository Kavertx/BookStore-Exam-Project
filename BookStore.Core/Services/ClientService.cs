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

        public async Task<int?> GetClientIdAsync(string userId)
        {
            return (await repository.AllReadOnly<Client>()
                .FirstOrDefaultAsync(c => c.UserId == userId))?.Id; 
        }
        public async Task<Client?> GetClientByIdAsync(int id)
        {
            return await repository.GetByIdAsync<Client>(id);
        }

        
    }
}
