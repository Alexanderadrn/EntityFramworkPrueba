﻿using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> ObtenerEstudiantes()
        {
            var resultado = await persona.ObtenerPersona();
            return Ok(resultado);

            //return new JsonResult(persona.ObtenerPersona());
        }
    }
}
