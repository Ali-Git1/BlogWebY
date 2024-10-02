using BlogWebY.Core.Entities;
using BlogWebY.Data.Repositories.Abstraction;
using BlogWebY.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebY.Data.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>()where T : class,IEntityBase,new();

        Task<int> SaveAsync();

        int Save();
    }
}
