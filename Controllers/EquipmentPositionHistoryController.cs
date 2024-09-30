using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forestTrack.Data.Interface;
using Microsoft.AspNetCore.Mvc;

namespace forestTrack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipmentPositionHistoryController : ControllerBase
    {
        public readonly IEquipmentPositionHistory _equipmentPositionHistory;

        public EquipmentPositionHistoryController(IEquipmentPositionHistory equipmentPositionHistory)
        {
            _equipmentPositionHistory = equipmentPositionHistory ?? throw new ArgumentNullException(nameof(equipmentPositionHistory));
        }

        [HttpGet]
         public IActionResult Get()
         {
            var equipmentsPosition = _equipmentPositionHistory.Get();
            return Ok(equipmentsPosition);
         }



    }
}