using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using AutoLot.Dal.Entities.Base;


#nullable disable

namespace AutoLot.Dal.Entities
{
    [Table("Inventory", Schema = "dbo")]
    public partial class Car : BaseEntity
    {
        [StringLength(50)]
        public string Make { get; set; }
        [StringLength(50)]
        public string Color { get; set; }
        [StringLength(50)]
        public string PetName { get; set; }

        [InverseProperty(nameof(Order.CarNavigation))]
        public virtual IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}
