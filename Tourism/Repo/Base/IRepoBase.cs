namespace Tourism.Repo.Base
{
    public interface IRepoBase<T> where T : class
    {
         Task<T> GetbyidAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);


    }
}
