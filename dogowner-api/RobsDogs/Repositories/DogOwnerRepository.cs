using System.Threading.Tasks;
using RobsDogs.Models.Api;
using RobsDogs.Models.Contracts;
using RobsDogs.Models.Domain;

namespace RobsDogs.Repositories
{
    public class DogOwnerRepository : IDogOwnerRepository
    {
        private readonly DogOwnerContext _context;

        public DogOwnerRepository(DogOwnerContext context)
        {
            _context = context;
        }
        public async Task Save(DogOwner dogOwner)
        {
            _context.DogOwners.Add(dogOwner);
            await _context.SaveChangesAsync();
        }

        public async Task<DogOwner> Get(long id)
        {
            return await _context.DogOwners.FindAsync(id);
        }
    }
}