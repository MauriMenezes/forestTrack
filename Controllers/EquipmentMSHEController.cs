using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forestTrack.Data.Interface;
using forestTrack.Data.repository;
using forestTrack.Models;
using forestTrack.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace forestTrack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipmentMSHEController : ControllerBase
    {
        private readonly IEquipmentMSHERepository _equipmentMSHERepository;
        public EquipmentMSHEController(IEquipmentMSHERepository equipmentMSHERepository)
        {
            _equipmentMSHERepository = equipmentMSHERepository;
        }

        //adicionar
        [HttpPost]
        public IActionResult Add(EquipmentMSHEViewModel equipmentMSHEViewModel)
        {
            var equipment = new EquipmentMSHE
            {
                EquipmentModelId = equipmentMSHEViewModel.Equipment_model_id,
                EquipmentStateId = equipmentMSHEViewModel.Equipment_state_id,
                value = equipmentMSHEViewModel.value
            };
            _equipmentMSHERepository.Add(equipment);
            return Ok(new { message = "Criado com sucesso!" });
        }


        // get all

        [HttpGet]
        public IActionResult Get()
        {
            var equipmentMSHE = _equipmentMSHERepository.Get();
            return Ok(equipmentMSHE);
        }
        ////Remove
        ///
        [HttpDelete("{equipment_model_id}")]
        public IActionResult RemoveEquipment(int equipment_model_id)
        {
            try
            {
                _equipmentMSHERepository.Remove(equipment_model_id);
                return Ok(new { message = "Deletado com sucesso!" });
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(new { message = "Equipamento não existe!" }); // Retorna 404 Not Found se não encontrar o equipamento
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Retorna 400 Bad Request para outros erros
            }
        }



    }
}