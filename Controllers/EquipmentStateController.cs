using System.Collections.Generic;
using forestTrack.Data.Interface;
using forestTrack.Models; // Certifique-se de que você tem a referência correta para o seu modelo
using Microsoft.AspNetCore.Mvc;

namespace forestTrack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipmentStateController : ControllerBase
    {
        private readonly IEquipmentStateRepository _equipmentStateRepository;

        // Construtor com injeção de dependência
        public EquipmentStateController(IEquipmentStateRepository equipmentStateRepository)
        {
            _equipmentStateRepository = equipmentStateRepository ?? throw new ArgumentNullException(nameof(equipmentStateRepository));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var equipmentStates = _equipmentStateRepository.Get();
            
            if (equipmentStates == null || !equipmentStates.Any())
            {
                return NotFound("No equipment states found.");
            }

            return Ok(equipmentStates);
        }
    }
}
