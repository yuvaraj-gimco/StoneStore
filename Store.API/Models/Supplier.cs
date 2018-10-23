using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.API.Models
{
    public class Supplier
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public long Id { get; set; }

            public string SupplierName { get; set; }

            public string SupplierCode { get; set; }

            public string SupplierAddress1 { get; set; }

            public string SupplierAddress2 { get; set; }

            public string CountryCode { get; set; }

            public long SupplierMobile { get; set; }

            public string ContactPersonName { get; set; }

            public long ContactPersonMobileNumber { get; set; }

            public string ContactPersonLandLine { get; set; }
            [DataType(DataType.EmailAddress)]
            [Display(Name = "Email Address")]
            [MaxLength(50)]
            [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Enter valid email address")]
            public string ContactPersonEmail { get; set; }

            public DateTime CreatedAt { get; set; }

            public DateTime UpdatedAt { get; set; }

            public string UpdatedBy { get; set; }
    }
}