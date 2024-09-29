using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forestTrack.Data.Interface;
using forestTrack.Models;

namespace forestTrack.Data.repository
{
    public class EquipmentModelRepository : IEquipmentModelRepository
    {
        private readonly ChallengeDBContext _context = new ChallengeDBContext();
        public void Add(EquipmentModel equipmentModel)
        {
            throw new NotImplementedException();
        }

        public List<EquipmentModel> Get()
        {
           return _context.equipment_model.ToList();
        }

        public void Remove(int equipmentModelId)
        {
            throw new NotImplementedException();
        }
    }
}