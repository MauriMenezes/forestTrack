using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forestTrack.Models;
using forestTrack.ViewModel;
using Microsoft.AspNetCore.Mvc;


namespace forestTrack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipmentController : ControllerBase
    {
        private readonly IequipmentRepository _equipmentRepository;

        public EquipmentController(IequipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository ?? throw new ArgumentNullException(nameof(equipmentRepository));
        }

        [HttpPost]
        public IActionResult Add(EquipmentViewModel equipmentView)
        {
            var equipment = new Equipment
            {
                
                EquipmentModelId = equipmentView.Equipment_model_id,
                Name = equipmentView.Name
            };

            _equipmentRepository.Add(equipment);
            return CreatedAtAction(nameof(Get), new { id = equipment.Id }, equipment);
        }


       
        [HttpGet]
        public IActionResult Get()
        {
            var equipments = _equipmentRepository.Get();
            return Ok(equipments);
        }


        ////// delete ///////
          [HttpDelete("{id}")]
        public IActionResult RemoveEquipment(int id)
        {
            try
            {
                _equipmentRepository.Remove(id);
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