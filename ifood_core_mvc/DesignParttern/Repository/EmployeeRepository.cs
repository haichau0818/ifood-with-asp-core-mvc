using ifood_core_mvc.Models;
using ifood_core_mvc.DesignParttern.Interfaces;
using ifood_core_mvc.Data;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ifood_core_mvc.DesignParttern.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(MyDBContext context) : base(context) { }


        public async Task<IEnumerable<Employee>> GetAllData(Expression<Func<Employee, bool>> where)
        {
            return await dbEntity.ToListAsync();
        }


        public async Task<IEnumerable<Employee>> GetAllData()
        {
            return await dbEntity.ToListAsync();
        }

        public async Task<Employee> GetDataByID(int ID)
        {
            return await dbEntity.FindAsync(ID);
        }

        public async Task<bool> Insert(Employee Model)
        {
            await dbEntity.AddAsync(Model);
            return true;
        }
        public async Task<bool> Update(Employee Model)
        {
            throw new NotImplementedException();

        }

        public Task<bool> Delete(Employee Model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Save()
        {
            throw new NotImplementedException();
        }

    }
}
