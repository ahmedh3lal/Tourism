using Microsoft.EntityFrameworkCore;
using Tourism.Models;
using Tourism.Repo.Base;

namespace Tourism.Repo
{
    public class MainRepo<T> : IRepoBase<T> where T : class
    {
        private AppDbContext _AppContext { get; set; }
        public MainRepo(AppDbContext appDbContext) 
        {
            _AppContext = appDbContext;
        }

        public async Task<T> GetbyidAsync(int id)
        {
            
            return await _AppContext.Set<T>().FindAsync(id); ;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
          
            return await _AppContext.Set<T>().ToListAsync(); 
        }

        public async Task<T> CreateAsync(T entity)
        {
            var res=await _AppContext.Set<T>().AddAsync(entity);    
            _AppContext.SaveChanges();
            return res.Entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
             _AppContext.Set<T>().Update(entity);
             await _AppContext.SaveChangesAsync() ;
            return entity;  
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            _AppContext.Set<T>().Remove(entity);
           await _AppContext.SaveChangesAsync();
            return true;    
        }

      
    }


}
