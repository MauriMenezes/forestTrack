using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace forestTrack.Models
{
    [Table("equipment")]
    public class EquipmentModel
    {
        [Key]
        [Column("id")]  
        public int Id { get; set; }
        
        [Column("equipment_model_id")]  
        public int EquipmentModelId { get; set; }
        
        [Column("name")]  
        public string? Name { get; set; }

        public EquipmentModel() { }

        public EquipmentModel(int id, int equipmentModelId, string name)
        {
            Id = id;
            EquipmentModelId = equipmentModelId;
            Name = name;
        }
    }
}