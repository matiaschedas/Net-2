using Portafolio.Models;

namespace Portafolio.Servicios.Interfaces
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }
}
