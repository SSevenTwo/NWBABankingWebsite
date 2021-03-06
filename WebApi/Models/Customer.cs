﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("Customer")]
    public partial class Customer
    {
        public Customer()
        {
            Account = new HashSet<Account>();
        }

        [Key]
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }
        [Column("TFN")]
        [StringLength(11)]
        public string Tfn { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(40)]
        public string City { get; set; }
        [StringLength(20)]
        public string State { get; set; }
        [StringLength(10)]
        public string PostCode { get; set; }
        [StringLength(14)]
        public string Phone { get; set; }

        [InverseProperty("Customer")]
        public virtual Login Login { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Account> Account { get; set; }
    }
}
