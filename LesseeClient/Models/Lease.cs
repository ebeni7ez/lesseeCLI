using System;

namespace LesseeClient.Models
{
    public class Lease
    {
        public Hardware Hardware { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Boolean Active { get; set; }
    }
}