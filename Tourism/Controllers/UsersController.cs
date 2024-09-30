using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tourism.Models;
using Tourism.Repo.Base;

namespace Tourism.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IRepoBase<Users> _Repo;
        public UsersController(IRepoBase<Users> repo)
        {
            _Repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFavorites()
        {

            var cat = await _Repo.GetAllAsync();
            return Ok(cat);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFavoritesbyID(int id)
        {

            var cat = await _Repo.GetbyidAsync(id);
            return Ok(cat);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFavorites(Users Users)
        {
            _Repo.CreateAsync(Users);
            return Ok(Users);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFavorites(Users Users)
        {
            _Repo.UpdateAsync(Users);
            return Ok(Users);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteFavorites(Users Users)
        {
            _Repo.DeleteAsync(Users);
            return Ok(Users);
        }

    }
}

