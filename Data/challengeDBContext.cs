using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forestTrack.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace forestTrack.Data
{
    public class ChallengeDBContext : DbContext
    {
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentState> equipment_state { get; set; }
        public DbSet<EquipmentModel> equipment_model { get; set; }
        public DbSet<EquipmentMSHE> equipment_model_state_hourly_earnings { get; set; }
         public DbSet<EquipmentPositionHistory> equipment_position_history { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(
          "Server=localhost;database=root;user=sa;password=root@123;encrypt=true;trustServerCertificate=true;"

        );

        internal object Find(int equipmentId)
        {
            throw new NotImplementedException();
        }
    }

    
}