using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _1_Request.Models
{
    public class Training
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
    }
}