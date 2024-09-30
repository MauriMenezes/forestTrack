using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forestTrack.Data.Interface;
using forestTrack.Models;

namespace forestTrack.Data.repository
{
    public class EquipmentPositionHistoryRepository:IEquipmentPositionHistory
    {
        private readonly ChallengeDBContext _context = new ChallengeDBContext();

        public List<EquipmentPositionHistory> Get()
        {
            return _context.equipment_position_history.ToList();
        }
    }
}