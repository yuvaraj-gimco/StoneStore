using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class Slab
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SlabId { get; set; }

        public string SlabIdentity { get; set; }

        public long Thickness { get; set; }

        public long Width { get; set; }

        public long Length { get; set; }

        public string Image { get; set; }

        public string ImageName { get; set; }

        public string ExternalAttribute { get; set; }

        public string ThumbImage { get; set; }

        public string BarCode { get; set; }

        [ForeignKey("Lots")]
        
        public long LotId { get; set; }

        [ForeignKey("OrderDetails")]
        public long? OrderDetailsId { get; set; }

        public long SlabStatusId { get; set; }

        public long SlabSqfts { get; set; }

        [ForeignKey("SlabShape")]
        public long SlabShapeId { get; set; }

        public virtual SlabShape SlabShape { get; set; }

        public string Shape { get; set; }

        public virtual Lot Lot { get; set; }


        public virtual OrderDetail OrderDetail { get; set; }
    }
}