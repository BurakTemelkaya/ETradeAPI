using ETradeAPI.Application.Repositories;
using ETradeAPI.Domain.Entites;
using ETradeAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeAPI.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ETradeAPIDbContext context) : base(context)
        {
        }
    }
}
