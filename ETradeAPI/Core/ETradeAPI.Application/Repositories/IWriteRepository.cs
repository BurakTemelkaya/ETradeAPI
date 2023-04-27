using ETradeAPI.Domain.Entites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T Model);

        Task<bool> AddRangeAsync(List<T> datas);

        bool Remove(T datas);

        Task<bool> Remove(string id);

        bool RemoveRange(List<T> datas);

        bool Update(T datas);

        Task<int> SaveAsync();
    }
}
