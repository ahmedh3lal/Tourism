using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tourism.Models;
using Tourism.Repo.Base;

namespace Tourism.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private IRepoBase<Category> _Repo;
        public CategoryController(IRepoBase<Category> repo)
        {
            _Repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
          
            var cat=await _Repo.GetAllAsync();
            return Ok(cat);
        }
         [HttpGet("{id}")]
        public async Task<IActionResult> GetCategorybyID(int id)
        {
          
            var cat=await _Repo.GetbyidAsync(id);
            return Ok(cat);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            _Repo.CreateAsync(category);    
            return Ok(category);
        }
        [HttpPut]
         public async Task<IActionResult> UpdateCategory(Category category)
        {
            _Repo.UpdateAsync(category);    
            return Ok(category);
        }
        [HttpDelete]
          public async Task<IActionResult> DeleteCategory(Category category)
        {
            _Repo.DeleteAsync(category);    
            return Ok(category);
        }

    }
}
