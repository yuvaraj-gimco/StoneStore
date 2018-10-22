using System;

namespace Store.API.Models
{
    public class Color
    {
        public long Id { get; set; } 

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }    

        public string  CreatedBy { get; set; } 

        public string ExtraAttribute { get; set; }

    }
}