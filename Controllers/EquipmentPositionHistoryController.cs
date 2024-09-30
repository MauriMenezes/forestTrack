using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forestTrack.Data.Interface;
using forestTrack.Models;
using forestTrack.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace forestTrack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipmentPositionHistoryController : ControllerBase
    {
        private readonly IEquipmentPositionHistory _IEquipmentPositionHistory;

        public EquipmentPositionHistoryController(IEquipmentPositionHistory equipmentPositionHistory)
        {
            _IEquipmentPositionHistory = equipmentPositionHistory;
        }



        [HttpPost]
         public IActionResult Add(EquipmentPositionHistoryVieModel equipmentPositionHistoryVieModel)
         {
            
            var equipment = new EquipmentPositionHistory
            {
                EquipmentId = equipmentPositionHistoryVieModel.Equipment_id,
                Date =DateTime.UtcNow,
                Longitude = equipmentPositionHistoryVieModel.lon,
                Latitude = equipmentPositionHistoryVieModel.lat
            };
            _IEquipmentPositionHistory.Add(equipment);
            return CreatedAtAction(nameof(Get), new { EquipmentId = equipment.EquipmentId }, equipment);
         }
        [HttpGet]
         public IActionResult Get()
         {
            var equipmentsPosition = _IEquipmentPositionHistory.Get();
            return Ok(equipmentsPosition);
         }
          [HttpDelete("{id}")]
           public IActionResult RemoveEquipment(int id)
        {
            try
            {
                _IEquipmentPositionHistory.Remove(id);
                return Ok(new { message = "Deletado com sucesso!" });
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(new { message = "Equipamento não existe!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Retorna 400 Bad Request para outros erros
            }
        }



    }
}