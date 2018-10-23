using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long Quantity { get; set; }

        public long CostOfProduct { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string ExtendedAttribute { get; set; }



        [ForeignKey("Order")]
        public long OrderId { get; set; }

        [ForeignKey("Lot")]
        public long LotId { get; set; }

        public virtual Order Orders { get; set; }

        public virtual Lot Lots { get; set; }

        public virtual List<Slab> Slabs { get; set; }
    }
}