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
    public class EquipmentModelController : ControllerBase
    {
        private readonly IEquipmentModelRepository _equipmentModelRepository;


        public EquipmentModelController(IEquipmentModelRepository equipmentModelRepository)
        {
            _equipmentModelRepository = equipmentModelRepository ??
            throw new ArgumentNullException(nameof(equipmentModelRepository));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var equipmentModels = _equipmentModelRepository.Get();

            return Ok(equipmentModels);
        }

    }
    
}