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
    public class EquipmentModelController : ControllerBase
    {
         private readonly IEquipmentModelRepository _equipmentModelRepository;

    public EquipmentModelController(IEquipmentModelRepository equipmentModelRepository)
    {
        _equipmentModelRepository = equipmentModelRepository;
    }

    [HttpPost]
    public IActionResult Add(EquipmentModel_View equipmentModel_View)
    {

        var equipmentModel = new EquipmentModel
        {
            Name = equipmentModel_View.Name
        };

        _equipmentModelRepository.Add(equipmentModel);

          return CreatedAtAction(nameof(Get), new { id = equipmentModel.Id }, equipmentModel);
    }

        [HttpGet]
        public IActionResult Get()
        {
            var equipmentModels = _equipmentModelRepository.Get();

            return Ok(equipmentModels);
        }

    }
    
}