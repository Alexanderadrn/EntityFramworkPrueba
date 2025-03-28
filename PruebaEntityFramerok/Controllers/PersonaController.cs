using Microsoft.AspNetCore.Mvc;
using PruebaEntityFramerok.Service;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaEntityFramerok.Controllers
{
    public class PersonaController : Controller
    {
        public IPersonaService persona;
        public PersonaController(IPersonaService _persona)
        {
            this.persona = _persona;
        }

        [HttpGet("ObtenerPersonasEntity")]
        public async Task<IActionResult> ObtenerEstudiantes([FromQuery] string cedula)
        {

            var resultado = await persona.ObtenerPersona(cedula);
            return Ok(resultado);

            //return new JsonResult(persona.ObtenerPersona());
        }
    }
}
