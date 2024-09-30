using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forestTrack.Models;

namespace forestTrack.Data.Interface
{
    public interface IEquipmentPositionHistory
    {
        List<EquipmentPositionHistory> Get();
    }
}