using Microsoft.EntityFrameworkCore;
using PruebaEntityFramerok.Dto;
using PruebaEntityFramerok.Models;

namespace PruebaEntityFramerok.Service
{
    public class PersonaService : IPersonaService
    {
        private PruebaEntityContext _context;

        public PersonaService(PruebaEntityContext context)
        {
            this._context = context;
        }

        public async Task<List<PersonaDTO>> ObtenerPersona(string cedula)
        {
            var personas = await _context.HckPersonas
             .Where(p => p.Cedula == cedula)
             .ToListAsync();
            List<PersonaDTO> listaPersonas = personas.Select(item => new PersonaDTO
            {
                Nombres = item.Nombres,
                Apellidos = item.Apellidos,
                Cedula = item.Cedula,
                Ciudadania = item.Ciudadania,
                FechaNacimiento = item.FechaNacimiento,
                EstadoCivil = item.EstadoCivil,
                Profesion = item.Profesion,
                NivelEstudios = item.NivelEstudios,
                EsCliente = item.EsCliente,
                TipoPersona = item.TipoPersona,
            }).ToList();
            return listaPersonas;
        }
    }
}
