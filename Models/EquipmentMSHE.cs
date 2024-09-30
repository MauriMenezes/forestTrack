using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace forestTrack.Models
{

    [Table("equipment_model_state_hourly_earnings")]
    public class EquipmentMSHE
     {
        [Key]
        [Column("equipment_model_id")]  
        public int EquipmentModelId { get; set; }
        
        [Column("equipment_state_id")]  
        public int EquipmentStateId { get; set; }
        
        [Column("value")]  
        public decimal  value { get; set; }

        public EquipmentMSHE() { }

        public EquipmentMSHE(int EquipmentModelId, int EquipmentStateId, decimal  value)
        {
            this.EquipmentModelId = EquipmentModelId;
            this.EquipmentStateId = EquipmentStateId;
            this.value= value;
        }
    }
}