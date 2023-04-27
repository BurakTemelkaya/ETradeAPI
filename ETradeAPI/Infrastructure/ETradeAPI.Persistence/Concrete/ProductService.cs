using ETradeAPI.Application.Abstractions;
using ETradeAPI.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeAPI.Persistence.Concrete
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new()
        {
            new()
            {
                Id=Guid.NewGuid(),CreatedDate=DateTime.Now,Name="Çorap",Price=50,Stock=25,
            },
            new()
            {
                Id=Guid.NewGuid(),CreatedDate=DateTime.Now,Name="Bisiklet",Price=5000,Stock=20,
            },
            new()
            {
                Id=Guid.NewGuid(),CreatedDate=DateTime.Now,Name="Telefon",Price=10000,Stock=10,
            }
        };

    }
}
