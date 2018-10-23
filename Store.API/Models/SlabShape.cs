using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class SlabShape
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

      
        public string Shape { get; set; }

        public long SlabId  { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpadatedAt { get; set; }

        public string UpadatedBy { get; set; }
    }
}