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
         
            var equipment = new EquipmentModel
            {
                EquipmentModelId = equipmentView.equipment_model_id,
                Name = equipmentView.name
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
    }
}