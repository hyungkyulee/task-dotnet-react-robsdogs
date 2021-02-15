using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RobsDogs.Models.Domain;
using RobsDogs.Services.Repositories;

namespace RobsDogs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogOwnersController : ControllerBase
    {
        private readonly DogOwnerRepository _memoryDbClient;

        public DogOwnersController(DogOwnerRepository memoryDbClient)
        {
            _memoryDbClient = memoryDbClient;
        }

        [HttpPost]
        public async Task<ActionResult<DogOwner>> AddDogOwner(DogOwner dogOwner)
        {
            _memoryDbClient.DogOwners.Add(dogOwner);
            await _memoryDbClient.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDogOwner),
                new {id = dogOwner.Id},
                dogOwner);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DogOwner>> GetDogOwner(long id)
        {
            var dogOwner = await _memoryDbClient.DogOwners.FindAsync(id);
            if (dogOwner == null)
            {
                return NotFound();
            }

            return dogOwner;
        }
    }
}