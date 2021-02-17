using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RobsDogs.Models.Api;
using RobsDogs.Models.Contracts;
using RobsDogs.Models.Domain;
using RobsDogs.Repositories;

namespace RobsDogs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogOwnersController : ControllerBase
    {
        private readonly IDogOwnerRepository _repository;

        public DogOwnersController(IDogOwnerRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> PostDogOwner(DogOwnerRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            
            var dogOwner = new DogOwner( request.OwnerName, request.DogName);
            await _repository.Save(dogOwner);

            return CreatedAtAction(nameof(PostDogOwner), new {id = dogOwner.Id}, null);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDogOwner(long id)
        {
            var dogOwner = await _repository.Get(id);
            if (dogOwner == null)
            {
                return NotFound();
            }
            
            var response = new DogOwnerResponse(dogOwner.Id,
                dogOwner.OwnerName,
                dogOwner.DogName);

            return Ok(response);
        }
    }
}