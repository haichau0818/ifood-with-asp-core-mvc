using ifood_core_mvc.Data;
using ifood_core_mvc.DesignParttern.Interfaces;
using ifood_core_mvc.DesignParttern.Repository;
using ifood_core_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace ifood_core_mvc.DesignParttern.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly MyDBContext _dbContext;

        //private GenericRepository<Product> productRepository;
        public IEmployeeRepository EmployeeRepository { get; private set; }


        public UnitOfWork(MyDBContext context,IEmployeeRepository employee)
        {
            _dbContext = context;
            EmployeeRepository = new EmployeeRepository(_dbContext);
        }

       
        public async Task CompleteAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
