using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class Lot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long LotId { get; set; }

        public string Identity { get; set; }

        public string Description { get; set; }

        public string ProfileImage { get; set; }

        public string QRCode { get; set; }

        public string Images { get; set; }

        public long Quantity { get; set; }

        public long Length { get; set; }

        public long Width { get; set; }

        public long Thickness { get; set; }

        public long TotalSqfts { get; set; }

        public long OneSlabSqfts { get; set; }

        public long PricePerSqft { get; set; }

        public double RewardPointMultiplier { get; set; }
        
        public bool Promotional { get; set; }

        public string Recommended { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool isPopular { get; set; }

        public bool isFeatured { get; set; }

        public bool isPromotional { get; set; }

        public long Likes { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime InWardDate { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

        public long Status { get; set; }

        public long CountryCode { get; set; }

        public long QuarryCode { get; set; }

        public string SellingCategory { get; set; }

        [ForeignKey("Material")]
        public long MeterialId { get; set; }

        public virtual Material Materials { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }

        public virtual List<QuotationDetail> QuotationDetails { get; set; }

        public virtual List<Slab> Slabs { get; set; }

        public string ExtendedAttribute { get; set; }

        public Lot()
        {
            this.OrderDetails = new List<OrderDetail>();
            this.QuotationDetails = new List<QuotationDetail>();
            this.Slabs = new List<Slab>();
        }

    }
}