using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tourism.Models;
using Tourism.Repo.Base;

namespace Tourism.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationController : ControllerBase
    {
        private IRepoBase<Destination> _Repo;
        public DestinationController(IRepoBase<Destination> repo)
        {
            _Repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDestination()
        {

            var cat = await _Repo.GetAllAsync();
            return Ok(cat);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDestinationbyID(int id)
        {

            var cat = await _Repo.GetbyidAsync(id);
            return Ok(cat);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDestination(Destination Destination)
        {
            _Repo.CreateAsync(Destination);
            return Ok(Destination);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDestination(Destination Destination)
        {
            _Repo.UpdateAsync(Destination);
            return Ok(Destination);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDestination(Destination Destination)
        {
            _Repo.DeleteAsync(Destination);
            return Ok(Destination);
        }

    }
}
