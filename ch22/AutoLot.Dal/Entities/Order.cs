using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using AutoLot.Dal.Entities.Base;

#nullable disable

namespace AutoLot.Dal.Entities
{
    public partial class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public int CarId { get; set; }

        [ForeignKey(nameof(CarId))]
        [InverseProperty(nameof(Car.Orders))]
        public virtual Car CarNavigation { get; set; }
        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("Orders")]
        public virtual Customer CustomerNavigation { get; set; }
    }
}
