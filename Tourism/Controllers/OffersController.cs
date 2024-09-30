using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tourism.Models;
using Tourism.Repo.Base;

namespace Tourism.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        private IRepoBase<Users> _Repo;
        public OffersController(IRepoBase<Users> repo)
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
        public async Task<IActionResult> CreateFavorites(Users Offers)
        {
            _Repo.CreateAsync(Offers);
            return Ok(Offers);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFavorites(Users Offers)
        {
            _Repo.UpdateAsync(Offers);
            return Ok(Offers);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteFavorites(Users Offers)
        {
            _Repo.DeleteAsync(Offers);
            return Ok(Offers);
        }

    }
}
