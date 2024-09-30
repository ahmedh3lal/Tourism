using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tourism.Models;
using Tourism.Repo.Base;

namespace Tourism.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class reviewsController : ControllerBase
    {
        private IRepoBase<Users> _Repo;
        public reviewsController(IRepoBase<Users> repo)
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
        public async Task<IActionResult> CreateFavorites(Users reviews)
        {
            _Repo.CreateAsync(reviews);
            return Ok(reviews);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFavorites(Users reviews)
        {
            _Repo.UpdateAsync(reviews);
            return Ok(reviews);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteFavorites(Users reviews)
        {
            _Repo.DeleteAsync(reviews);
            return Ok(reviews);
        }

    }
}
