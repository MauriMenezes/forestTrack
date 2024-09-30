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
    // Verificar se o EquipmentState existe
    var equipmentStateExist = _context.equipment_state.Find(equipmentMSHE.EquipmentStateId);
    if (equipmentStateExist == null)
    {
        throw new InvalidOperationException("Equipment_state_Id nao existe!");
    }

    // Verificar se s já existe
    var existingEarnings = _context.equipment_model_state_hourly_earnings
        .FirstOrDefault(e => e.EquipmentModelId == equipmentMSHE.EquipmentModelId 
                          && e.EquipmentStateId == equipmentMSHE.EquipmentStateId);

    //verificar duplo
    if (existingEarnings != null)
    {
        throw new InvalidOperationException("Já existe ! ");
    }

    // Adicionar o novo registro
    _context.equipment_model_state_hourly_earnings.Add(equipmentMSHE);
    _context.SaveChanges();
}

        public List<EquipmentMSHE> Get()
        {
            return _context.equipment_model_state_hourly_earnings.ToList();
        }

        public void Remove(int equipmentModelId)
        {
            var equipment = _context.Equipments.Find(equipmentModelId);

            if (equipment == null)
            {
                throw new InvalidOperationException("Equipment not found.");
            }

            _context.Equipments.Remove(equipment);
            _context.SaveChanges();
        }
    }
}