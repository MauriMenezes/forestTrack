using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forestTrack.Models
{
    public interface IequipmentRepository
    {
        void Add(EquipmentModel equipment);
        List<EquipmentModel> Get();
    }
}