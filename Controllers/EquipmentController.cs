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
        [HttpGet]
         
         public ActionResult<List<EquipmentModel>> GetAllEquipments()
         {
            return Ok();
         }
    }
}