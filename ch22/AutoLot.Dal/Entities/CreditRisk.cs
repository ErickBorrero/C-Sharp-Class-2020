using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using AutoLot.Dal.Entities.Base;
using AutoLot.DAL.Entities.Owned;

#nullable disable

namespace AutoLot.Dal.Entities
{
    public partial class CreditRisk : BaseEntity
    {
        public int CustomerId { get; set; }
        
        public Person PersonalInformation {get; set;} = new Person();
        
        [ForeignKey(nameof(CustomerId))]
        [InverseProperty(nameof(Customer.CreditRisks))]
        public virtual Customer CustomerNavigation { get; set; }
    }
}
