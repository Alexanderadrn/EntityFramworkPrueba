using Microsoft.AspNetCore.Mvc;
using PruebaEntityFramerok.Service;

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
        public ActionResult ObtenerEstudiantes()
        {
            return new JsonResult(persona.ObtenerPersona());
        }
    }
}
