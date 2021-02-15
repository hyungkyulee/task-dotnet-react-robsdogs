using Microsoft.EntityFrameworkCore;
using RobsDogs.Models.Domain;

namespace RobsDogs.Repositories
{
    public class DogOwnerContext : DbContext
    {
        public DogOwnerContext(DbContextOptions<DogOwnerContext> options) :base(options)
        {
        }
        
        public DbSet<DogOwner> DogOwners { get; set; }
    }
}