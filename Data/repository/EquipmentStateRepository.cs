using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forestTrack.Data.Interface;
using forestTrack.Models;

namespace forestTrack.Data.repository
{
    public class EquipmentStateRepository: IEquipmentStateRepository
    {
        private readonly ChallengeDBContext _context = new ChallengeDBContext();

        public List<EquipmentState> Get()
        {
            return _context.equipment_state.ToList();
        }

    }
}