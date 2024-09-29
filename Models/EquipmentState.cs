using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace forestTrack.Models
{
    public class EquipmentState
    {
        [Key]
        [Column("id")]  
        public int Id { get; set; }

        [Column("name")]  
        public string? Name { get; set; }

        [Column("color")]
        public string? Color { get; set; }

        public EquipmentState(int Id, string Name, string Color)
        {
            this.Id = Id;
            this.Name =Name;
            this.Color = Color;
        }

    }
}