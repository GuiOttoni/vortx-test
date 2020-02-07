using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaleMais.Domain.DTO;
using FaleMais.Infra.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FaleMais.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarifaController : ControllerBase
    {
        private ITarifaService tarifaService;

        public TarifaController(ITarifaService _tarifaService) : base()
        {
            tarifaService = _tarifaService;
        }

        // GET: api/Tarifa
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] RequestTarifa requestTarifa)
        {
            if (requestTarifa == null)
                return BadRequest();

            return Ok(await tarifaService.GetTarifas(requestTarifa));
        }
    }
}
