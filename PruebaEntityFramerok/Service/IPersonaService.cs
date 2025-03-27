using PruebaEntityFramerok.Dto;

namespace PruebaEntityFramerok.Service
{
    public interface IPersonaService
    {
        public Task<List<PersonaDTO>> ObtenerPersona(int pageNumber, int pageSize);
    }
}
