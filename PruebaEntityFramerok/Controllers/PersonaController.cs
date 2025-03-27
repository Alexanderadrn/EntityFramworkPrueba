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

        [HttpGet("ObtenerPersonas")]
        public async Task<IActionResult> ObtenerEstudiantes([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 1000)
        {

            var resultado = await persona.ObtenerPersona(pageNumber,pageSize);
            return Ok(resultado);

            //return new JsonResult(persona.ObtenerPersona());
        }
    }
}
