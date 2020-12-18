using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AutoLot.Dal.Models.Entities.Base;
using AutoLot.Dal.Models.Entities.Owned;
using System.Text.Json.Serialization;

namespace AutoLot.Dal.Models.Entities
{
    public partial class Customer : BaseEntity
    {
        public Person PersonalInformation { get; set; } = new Person();

        [JsonIgnore]
        [InverseProperty(nameof(CreditRisk.CustomerNavigation))]
        public virtual IEnumerable<CreditRisk> CreditRisks { get; set; } = new List<CreditRisk>();

        [JsonIgnore]
        [InverseProperty(nameof(Order.CustomerNavigation))]
        public virtual IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}