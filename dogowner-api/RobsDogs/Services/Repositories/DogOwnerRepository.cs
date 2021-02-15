using Microsoft.EntityFrameworkCore;
using RobsDogs.Models.Contracts;
using RobsDogs.Models.Domain;

namespace RobsDogs.Services.Repositories
{
    public class DogOwnerRepository : DbContext
    {
        public DogOwnerRepository(DbContextOptions<DogOwnerRepository> options) :base(options)
        {
        }
        
        public DbSet<DogOwner> DogOwners { get; set; }
    }
}