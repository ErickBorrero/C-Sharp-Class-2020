using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using AutoLot.Dal.Entities.Base;


#nullable disable

namespace AutoLot.Dal.Entities
{
    public partial class CreditRisk : BaseEntity
    {
        public int CustomerId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty(nameof(Customer.CreditRisks))]
        public virtual Customer CustomerNavigation { get; set; }
    }
}
