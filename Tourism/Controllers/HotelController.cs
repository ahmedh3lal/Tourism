using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tourism.Models;
using Tourism.Repo;
using Tourism.Repo.Base;

namespace Tourism.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        protected IRepoBase<Hotel> _Repo;
        private AppDbContext _appDbContext;
        public HotelController(IRepoBase<Hotel> repoBase, AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
             _Repo=repoBase;
        }
        [HttpGet]
        public  async Task<IActionResult> SelectAllHotel()
        {

            var res= await _Repo.GetAllAsync();
            return Ok(res);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> SelectHotelbyID([FromRoute] int id)
        {
            Hotel? res = await _Repo.GetbyidAsync(id);
            return Ok(res);
        }
        [HttpPost]
        public  async Task <IActionResult> CreateNewHotel(Hotel hotel)
        {
            await _Repo.CreateAsync(hotel);

            return Ok("Done");
        }
        [HttpPut("update")]
         public  async Task <IActionResult> UpdateHotel(Hotel hotel)
        {
            await _Repo.UpdateAsync(hotel);

            return Ok("Done");
        }
          [HttpDelete("Delete")]
         public  async Task <IActionResult> DeleteHotel(Hotel hotel)
        {
            await _Repo.DeleteAsync(hotel);

            return Ok("Done");
        }

    }
}
