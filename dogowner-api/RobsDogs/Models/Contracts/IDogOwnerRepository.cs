using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RobsDogs.Models.Domain;

namespace RobsDogs.Models.Contracts
{
    public interface IDogOwnerRepository
    {
        Task<ActionResult<DogOwner>> Save(DogOwner dogOwner);
        Task<ActionResult<DogOwner>> Get(long id);
    }
}