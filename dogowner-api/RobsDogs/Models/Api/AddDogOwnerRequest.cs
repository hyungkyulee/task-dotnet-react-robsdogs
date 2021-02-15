using System.Collections.Generic;

namespace RobsDogs.Models.Api
{
    public class AddDogOwnerRequest
    {
        public string OwnerName { get; set; }
        public List<string> DogNames { get; set; }
    }
}