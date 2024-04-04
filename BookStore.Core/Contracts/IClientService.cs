using BookStore.Core.Models.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Contracts
{
    public interface IClientService
    {
        Task<BookQueryServiceModel> AllFavouriteBooksAsync(string userId);
        Task<int?> GetClientIdAsync(string userId);
    }
}
