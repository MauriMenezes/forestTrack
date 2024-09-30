using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forestTrack.Data.Interface;
using forestTrack.Models;

namespace forestTrack.Data.repository
{
    public class EquipmentPositionHistoryRepository : IEquipmentPositionHistory
    {
        private readonly ChallengeDBContext _context = new ChallengeDBContext();

        public void Add(EquipmentPositionHistory equipmentPositionHistory)
          {
            if (equipmentPositionHistory == null)
            {
                throw new ArgumentNullException(nameof(equipmentPositionHistory), "EquipmentPositionHistory cannot be null.");
            }
            // Adicionar o novo registro
            _context.equipment_position_history.Add(equipmentPositionHistory);
            _context.SaveChanges();
        }
        public List<EquipmentPositionHistory> Get()
        {
            return _context.equipment_position_history.ToList();
        }
        public void Remove(int equipmentId)
        {
              var equipment = _context.Equipments.Find(equipmentId);
              if (equipment == null)
            {
                throw new InvalidOperationException("Equipment not found.");   
            }
             _context.Equipments.Remove(equipment);
            _context.SaveChanges();
        }
    }
}