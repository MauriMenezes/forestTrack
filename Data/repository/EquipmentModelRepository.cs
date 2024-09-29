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

             //verifica nome existente ou campo vazio

            if (string.IsNullOrWhiteSpace(equipmentModel.Name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(equipmentModel.Name));
            }
            var existingEquipment = _context.equipment_model
                .FirstOrDefault(e => e.Name.ToLower() == equipmentModel.Name.ToLower());

            if (existingEquipment != null)
            {
                throw new InvalidOperationException("Equipment already exists.");
            }


           _context.equipment_model.Add(equipmentModel);
            _context.SaveChanges();
        }

        public List<EquipmentModel> Get()
        {
           return _context.equipment_model.ToList();
        }

        public void Remove(int equipmentModelId)
        {
            var equipmentModel = _context.equipment_model.Find(equipmentModelId);

             if (equipmentModel == null)
            {
                throw new InvalidOperationException("Equipment not found.");
            }

            _context.equipment_model.Remove(equipmentModel);
            _context.SaveChanges(); 
        }
    }
}