namespace Portafolio.Models
{
    public class ProyectoDTO
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<string> ImagenesURL { get; set; } = new List<string>();
        public string Link { get; set; }
        public int Id { get; set; } 
        public List<string> Tecnologias { get; set; } = new List<string>();
        public List<string> Funcionalidades { get; set; } = new List<string>();
    }
}
