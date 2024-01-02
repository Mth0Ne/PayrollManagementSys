using PayrollManagementSys.Data.Context;
using PayrollManagementSys.Data.Repositories.Abstract;
using PayrollManagementSys.Data.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public ValueTask DisposeAsync()
        {
            return dbContext.DisposeAsync();
        }

        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            return new Repository<T>(dbContext);
        }

        public int Save()
        {
            return dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
    }
}
