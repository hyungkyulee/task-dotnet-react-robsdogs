using System.Collections.Generic;

namespace RobsDogs.Models.Api
{
    public class AddDogOwnerRequest
    {
        public string OwnerName { get; set; }
     
        public string DogName { get; set; }
        // public IList<string> DogNames { get; set; } = new List<string>();
    }
}