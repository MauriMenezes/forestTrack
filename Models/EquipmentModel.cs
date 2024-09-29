using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace forestTrack.Models
{
    [Table("equipment")]
    public class EquipmentModel
    {
        public int id { get; set; }
        public int equipment_model_id { get; set; }
        public string? name { get; set; }

        public EquipmentModel(int id,int equipment_model_id,string name)
        {
            this.id = id;
            this.equipment_model_id = equipment_model_id;
            this.name = name ;
            
        }


    }
    
}