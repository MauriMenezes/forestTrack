using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forestTrack.ViewModel
{
    public class EquipmentViewModel
    {
        public int Equipment_model_id { get; set; }

        required
        public string Name { get; set; }
    }
}