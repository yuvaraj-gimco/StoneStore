using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class SlabThickness
    {
         [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

     
        public long Thickness { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpadatedAt { get; set; }

        public string UpdatedBy { get; set; }
    }
}