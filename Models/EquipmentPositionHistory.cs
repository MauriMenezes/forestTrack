using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace forestTrack.Models
{
    public class EquipmentPositionHistory
    {
        [Key]
        [Column("equipment_id")]  
        public int EquipmentId { get; set; }

        [Column("date")]  
        public DateTime Date { get; set; } 

        [Column("lat")]
        public decimal Latitude { get; set; } 

        [Column("lon")]
        public decimal Longitude { get; set; }

        // Construtor
        public EquipmentPositionHistory(int equipmentId, DateTime date, decimal latitude, decimal longitude)
        {
            EquipmentId = equipmentId;
            Date = date;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
