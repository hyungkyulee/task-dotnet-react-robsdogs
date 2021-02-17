using System.Collections.Generic;

namespace RobsDogs.Models.Api
{
    public class DogOwnerResponse
    {
        public long Id { get; }
        public string OwnerName { get; }
        public string DogName { get; }

        public DogOwnerResponse(long id, 
            string ownerName,
            string dogName)
        {
            Id = id;
            OwnerName = ownerName;
            DogName = dogName;
        }
    }
}