using ifood_core_mvc.DesignParttern.Repository;
using ifood_core_mvc.DesignParttern.Interfaces;
using ifood_core_mvc.Models;

namespace ifood_core_mvc.DesignParttern.Interfaces
{
    public interface IUnitOfWork
    {
       
        IEmployeeRepository EmployeeRepository { get; }
        Task CompleteAsync();
    }
}
