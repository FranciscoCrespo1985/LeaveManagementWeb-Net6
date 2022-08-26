namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<T> AddAsync(T entity);
        Task<bool> Exist(int id); 
        Task DeleteAsync(int id);
        Task<List<T>> GetAllAsync();
        Task UpdateAsync(T entity);  
           
    }
}
