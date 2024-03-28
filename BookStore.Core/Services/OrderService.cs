using BookStore.Core.Contracts;
using BookStore.Infrastructure.Data.Common;
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
        public OrderService(IRepository _repository)
        {
            repository = _repository;
        }
    }
}
