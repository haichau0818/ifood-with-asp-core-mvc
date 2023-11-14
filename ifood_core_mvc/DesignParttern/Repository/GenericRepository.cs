using ifood_core_mvc.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;
using ifood_core_mvc.DesignParttern.Interfaces;

namespace ifood_core_mvc.DesignParttern.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private MyDBContext DbContext;
        internal DbSet<T> dbEntity;

        public GenericRepository(MyDBContext DbContext)
        {
            this.DbContext = DbContext;
            dbEntity = DbContext.Set<T>();
        }
    
        public async Task<IEnumerable<T>> GetAllData(Expression<Func<T, bool>> where)
        {
               return await dbEntity.ToListAsync();
        }


        public async Task<IEnumerable<T>> GetAllData()
        {
            return await dbEntity.ToListAsync();
        }

        public async Task<T> GetDataByID(int ID)
        {
            return await dbEntity.FindAsync(ID);
        }

        public async Task<bool> Insert(T Model)
        {
            await dbEntity.AddAsync(Model);
            return true;
        }
        public Task<bool> Update(T Model, int ID)
        {
            throw new NotImplementedException();

        }

        public Task<bool> Delete(T Model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Save()
        {
            throw new NotImplementedException();
        }
    }
}
