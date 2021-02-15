using System.Collections.Generic;

namespace RobsDogs.Models.Api
{
    public class DogOwnerResponse
    {
        public long Id { get; set; }
        public string OwnerName { get; set; }
        // public List<string> DogNames { get; set; }
        public string DogName { get; set; }
    }
}