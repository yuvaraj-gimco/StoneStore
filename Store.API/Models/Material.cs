using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class Material
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Name { get; set; }

        public string ReferenceImage { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        
        public string UpdatedBy { get; set; }

        [ForeignKey("Color")]
        public long ColorId { get; set; }

        public virtual Color Color { get; set; }

        public virtual List<Lot> Lots { get; set; }

        public string ExtendedAttribute { get; set; }


        public Material()
        {
            this.Lots = new List<Lot>();

        }
    }
}