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

        public async Task<List<PersonaDTO>> ObtenerPersona()
        {
            List<PersonaDTO> listaPersonas = new List<PersonaDTO>();
            var personas = await _context.HckPersonas.ToListAsync();
            foreach (var item in personas)
            {
                PersonaDTO persona = new PersonaDTO
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
                };
                listaPersonas.Add(persona);
            }
            return listaPersonas;
        }
    }
}
