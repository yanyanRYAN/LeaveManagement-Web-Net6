namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        //generic handling of basic crud
        Task<T> GetAsync(int? id);

        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<bool> Exists(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);


    }
}

