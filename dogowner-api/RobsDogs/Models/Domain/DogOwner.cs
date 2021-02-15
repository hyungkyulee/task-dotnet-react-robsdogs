using System.Collections.Generic;

namespace RobsDogs.Models.Domain
{
    public class DogOwner
    {
        public long Id { get; }

        public string OwnerName { get; }

        public List<string> DogNames { get; }

        public DogOwner(long id,
            string ownerName,
            List<string> dogNames)
        {
            Id = id;
            OwnerName = ownerName;
            DogNames = dogNames;
        }
    }
}