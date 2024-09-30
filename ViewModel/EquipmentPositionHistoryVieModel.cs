using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forestTrack.ViewModel
{
    public class EquipmentPositionHistoryVieModel
    {
        public int Equipment_id {get;set;}

        public DateTime date {get;set;}

        public decimal lat {get;set;}
        public decimal lon {get;set;}

        
    }
}