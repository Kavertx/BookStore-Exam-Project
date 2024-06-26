﻿using BookStore.Core.Models.Book;
using BookStore.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Contracts
{
    public interface IClientService
    {
        Task<int?> GetClientIdAsync(string userId);
        Task<Client?> GetClientByIdAsync(int id);
       
    }
}
