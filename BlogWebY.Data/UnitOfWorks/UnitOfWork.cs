using BlogWebY.Data.Context;
using BlogWebY.Data.Repositories.Abstraction;
using BlogWebY.Data.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebY.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async ValueTask DisposeAsync()
        {
            await dbContext.DisposeAsync();
        }

        public int Save()
        {
            return dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

        IRepository<T> IUnitOfWork.GetRepository<T>()
        {
            return new Repository<T>(dbContext);
        }
    }
}
