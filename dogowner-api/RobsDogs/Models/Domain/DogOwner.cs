using System.Collections.Generic;

namespace RobsDogs.Models.Domain
{
    public class DogOwner
    {
        public long Id { get; set; }

        public string OwnerName { get; set; }

        // public List<string> DogNames { get; set; }
        public string DogName { get; set; }

        // public DogOwner(long id,
        //     string ownerName,
        //     List<string> dogNames)
        // {
        //     Id = id;
        //     OwnerName = ownerName;
        //     DogNames = dogNames;
        // }
    }
}