using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using AutoLot.Dal.Entities.Base;


#nullable disable

namespace AutoLot.Dal.Entities
{
    public partial class Customer : BaseEntity
    {
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }

        [InverseProperty(nameof(CreditRisk.CustomerNavigation))]
        public virtual IEnumerable<CreditRisk> CreditRisks { get; set; } = new List<CreditRisk>();
        [InverseProperty(nameof(Order.CustomerNavigation))]
        public virtual IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}
