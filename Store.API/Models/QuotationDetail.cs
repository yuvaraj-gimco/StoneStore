using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class QuotationDetail
    {
        public long Id { get; set; }

        public long SqftRequired { get; set; }

        public long Thickness { get; set; }

        public string Requirement { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string ExtendedAttribute { get; set; }

        
        [ForeignKey("Quotation")]
        public long QuoteId { get; set; }

        [ForeignKey("Lot")]
        public long LotId { get; set; }

        public virtual Quotation Quotation { get; set; }

        public virtual Lot Lot { get; set; }
    }
}