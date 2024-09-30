using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forestTrack.Data.repository;
using forestTrack.Models;

namespace forestTrack.Data.Interface
{
    public interface IEquipmentMSHERepository
    {
        void Add(EquipmentMSHE equipmentMSHE);

        List<EquipmentMSHE> Get();

        void Remove (int equipmentModelId);
    }
}