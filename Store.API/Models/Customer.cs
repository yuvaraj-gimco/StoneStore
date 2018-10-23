using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Role { get; set; }
        public long SalesPersonId { get; set; }

        public string UId { get; set; }

        public string Token { get; set; }

        public string COAId { get; set; }

        public bool IsUpdated { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Contact { get; set; }

        
        public string Email { get; set; }

        public string Password { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
        
        public DateTime DOB { get; set; }

        public string Company { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string State { get; set; }

        public long ZipCode { get; set; }

        public string LookingFor { get; set; }

        public long RewardPoints { get; set; }

        public long SqftsSold { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

        public string Photo { get; set; }

        public string ExtendedAttribute { get; set; }

        public bool IsIos { get; set; }

        public virtual List<Order> Orders { get; set; }

        public virtual List<Quotation> Quotations { get; set; }

        public Customer()
        {
            this.Orders = new List<Order>();
            this.Quotations = new List<Quotation>();
        }
    }
}