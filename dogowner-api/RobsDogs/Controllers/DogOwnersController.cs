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
        public async Task<ActionResult<DogOwner>> AddDogOwner(AddDogOwnerRequest request)
        {
            var dogOwner = new DogOwner();
            dogOwner.OwnerName = request.OwnerName;
            dogOwner.DogName = request.DogName;

            await _repository.Save(dogOwner);
            
            return CreatedAtAction(nameof(AddDogOwner),
                new {id = dogOwner.Id},
                dogOwner);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DogOwner>> GetDogOwner(long id)
        {
            // var dogOwner = await _repository.DogOwners.FindAsync(id);
            // if (dogOwner == null)
            // {
            //     return NotFound();
            // }
            //
            // return dogOwner;
            return Ok(new DogOwner());
        }
    }
}