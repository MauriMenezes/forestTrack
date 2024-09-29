using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forestTrack.Models;

namespace forestTrack.Data.Interface
{
    public interface IEquipmentModelRepository
    {
        void Add(EquipmentModel equipmentModel);
        List<EquipmentModel> Get();
        void Remove (int equipmentModelId);
    }
}