using System;

namespace LesseeClient.Models
{
    public class Hardware
    {
        public string Name { get; set; }
        public string IP { get; set; }
        public bool Leased { get; set; }
        public Platform Platform { get; set; }
    }
}