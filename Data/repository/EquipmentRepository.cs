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

        // ADD equipment
        public void Add(Equipment equipment)
        {

            //Verifico equipment_model_id

             var ExistEquipment_Model_id = _context.Equipments.Any(item => item.Id == equipment.EquipmentModelId);

             if(!ExistEquipment_Model_id)
             {
                throw new InvalidOperationException("Equipment id doens't exist!");
             }
             
             //verifica nome existente ou campo vazio

            if (string.IsNullOrWhiteSpace(equipment.Name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(equipment.Name));
            }
            var existingEquipment = _context.Equipments
                .FirstOrDefault(e => e.Name.ToLower() == equipment.Name.ToLower());

            if (existingEquipment != null)
            {
                throw new InvalidOperationException("Equipment already exists.");
            }

            _context.Equipments.Add(equipment);
            _context.SaveChanges();
        }

        // List equipment
        public List<Equipment> Get()
        {
            return _context.Equipments.ToList();
        }

        // remove Equipmet
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