using System.Linq.Expressions;

namespace ifood_core_mvc.DesignParttern.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<bool> Insert(T Model); // 

        Task<IEnumerable<T>> GetAllData();

        Task<IEnumerable<T>> GetAllData(Expression<Func<T, bool>> where);

        Task<T> GetDataByID(int ID);

        Task<bool> Update(T Model, int ID);

        Task<bool> Delete(T Model);

        Task<bool> Save();
    }
}
