using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forestTrack.Data.Interface;
using forestTrack.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace forestTrack.Data.repository
{
    public class EquipmentMSHERepository : IEquipmentMSHERepository
    {

        private readonly ChallengeDBContext _context = new ChallengeDBContext();

        public void Add(EquipmentMSHE equipmentMSHE)
        {
            throw new NotImplementedException();
        }

        public List<EquipmentMSHE> Get()
        {
            return _context.equipment_model_state_hourly_earnings.ToList();
        }

        public void Remove(int equipmentModelId)
        {
            throw new NotImplementedException();
        }
    }
}