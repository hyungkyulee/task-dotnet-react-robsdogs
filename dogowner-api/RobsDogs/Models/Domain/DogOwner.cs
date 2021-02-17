using System.Collections.Generic;

namespace RobsDogs.Models.Domain
{
    public class DogOwner
    {
        public long Id { get; set; }

        public string OwnerName { get; set; }

        public string DogName { get; set; }
        // public List<string> DogNames { get; set; } = new List<string>();

        public DogOwner(long id,
            string ownerName,
            string dogName)
        {
            Id = id;
            OwnerName = ownerName;
            DogName = dogName;
        }
        
        public DogOwner(string ownerName,
            string dogName)
        {
            OwnerName = ownerName;
            DogName = dogName;
        }
    }
}