using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace forestTrack.Models
{
     [Table("equipment_model")]
    public class EquipmentModel
    {
        [Key]
        [Column("id")]  
        public int Id { get; set; }
        [Column("name")]  
        public string? Name { get; set; }

        public EquipmentModel(){}

        public EquipmentModel (int Id,String Name)
        {
            this.Id = Id;
            this.Name= Name;
        }
    }
}