using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class Quotation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long QuoteId { get; set; }

        [ForeignKey("Customer")]
        public long CustomerId { get; set; }

        public string ClientName { get; set; }

        public long TotalSqftsReq { get; set; }
        
         public string Description { get; set; }

        public string ExtendedAttribute { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string Status { get; set; }


        public Customer Customer { get; set; }



        public virtual List<QuotationDetail> QuotationDetails { get; set; }

        public Quotation()
        {
            this.QuotationDetails = new List<QuotationDetail>();
        }
    }
}