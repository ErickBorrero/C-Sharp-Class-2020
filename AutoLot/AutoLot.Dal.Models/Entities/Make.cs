using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoLot.Dal.Models.Entities.Base;
using System.Text.Json.Serialization;

namespace AutoLot.Dal.Models.Entities
{
    public class Make : BaseEntity
    {
        [StringLength(50),Required]
        public string Name { get; set; }

        [JsonIgnore]
        [InverseProperty(nameof(Car.MakeNavigation))]
        public IEnumerable<Car> Cars { get; set; } = new List<Car>();

    }
}