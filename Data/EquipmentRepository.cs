using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forestTrack.Models;

namespace forestTrack.Data
{
    public class EquipmentRepository : IequipmentRepository
    {
        private readonly ChallengeDBContext _context = new ChallengeDBContext();
        public void Add(EquipmentModel equipment)
        {
            _context.Equipments.Add(equipment);
            _context.SaveChanges();
        }

        public List<EquipmentModel> Get()
        {
            return _context.Equipments.ToList();
        }
    }
}