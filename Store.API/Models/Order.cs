using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrderId { get; set; }

        public string ClientName { get; set; }  
        public string ShippingAddress1 { get; set; }

        public string ShippingAddress2 { get; set; }

        public string State { get; set; }

        public long ZipCode { get; set; }

        public long ShippingCharges { get; set; }

        public long OrderCost { get; set; }

        public long ServiceTax { get; set; }

        public long TotalCost { get; set; }

        public long TotalSqfts { get; set; }

        

        public DateTime DueDate { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        

        public string Status { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

        

        public string ExtendedAttribute { get; set; }



        public string ExternalFiles { get; set; }



        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }
        
        

        [ForeignKey("Employee")]
        public long EmployeeId { get; set; }

        [ForeignKey("Customer")]
        public long CustomerId { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            this.OrderDetails = new List<OrderDetail>();
        }
    }
}