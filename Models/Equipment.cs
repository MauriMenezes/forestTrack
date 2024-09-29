using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace forestTrack.Models
{
    [Table("equipment")]
    public class Equipment
    {
        [Key]
        [Column("id")]  
        public int Id { get; set; }
        
        [Column("equipment_model_id")]  
        public int EquipmentModelId { get; set; }
        
        [Column("name")]  
        public string? Name { get; set; }

        public Equipment() { }

        public Equipment(int Id, int EquipmentModelId, string Name)
        {
            this.Id = Id;
            this.EquipmentModelId = EquipmentModelId;
            this.Name = Name;
        }
    }
}