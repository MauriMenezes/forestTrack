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
    public class EquipmentMSHEController : ControllerBase
    {
        private readonly IEquipmentMSHERepository _equipmentMSHERepository;
        public EquipmentMSHEController(IEquipmentMSHERepository equipmentMSHERepository)
        {
            _equipmentMSHERepository = equipmentMSHERepository;
        }

        //adicionar


        // get all

        [HttpGet]
        public IActionResult Get()
        {
            var equipmentMSHE = _equipmentMSHERepository.Get();
            return Ok(equipmentMSHE);
        }


    }
}