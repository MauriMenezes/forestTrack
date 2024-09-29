using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using forestTrack.Models;
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
            _equipmentRepository = equipmentRepository ?? throw new ArgumentNullException();
        }

        [HttpGet]
         
         public IActionResult Get()
         {
            var equipments = _equipmentRepository.Get();
            return Ok(equipments);
         }
    }
}