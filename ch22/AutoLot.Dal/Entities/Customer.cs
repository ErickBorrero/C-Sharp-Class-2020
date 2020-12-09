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
        public Person PersonalInformation {get; set;} = new Person();

        [InverseProperty(nameof(CreditRisk.CustomerNavigation))]
        public virtual IEnumerable<CreditRisk> CreditRisks { get; set; } = new List<CreditRisk>();
        [InverseProperty(nameof(Order.CustomerNavigation))]
        public virtual IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}
