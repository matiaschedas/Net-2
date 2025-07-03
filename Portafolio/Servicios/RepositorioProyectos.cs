using Portafolio.Models;
using Portafolio.Servicios.Interfaces;

namespace Portafolio.Servicios
{
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>()
            {
                new ProyectoDTO
                {
                    Titulo = "Verde Mercado",
                    Descripcion ="Verde Mercado es un E-Commerce para un cliente. Fue realizado en ASP.NET Core MVC, actualmente se encuentra funcionando en ambiente productivo",
                    Tecnologias = new List<string>
                    {
                        "ASP.Net MVC",
                        "Role-based Authorization",
                        "ASP.Net Core Identity",
                        "Entity Framework",
                        "SQL Server",
                        "HTML",
                        "CSS",
                        "JavaScript",
                        "Bootstrap",
                        "JQuery",
                        "Ajax"
                    },
                    Funcionalidades = new List<string>
                    {
                        "Manejo de usarios (Registro, Login, Recuperación de cuenta, Edición de perfil)",
                        "Manejo de Funcionalidades segun rol del usuario",
                        "Administrador: Manejo de Productos, Pedidos, Ordenes, Usuarios",
                        "Usuario: Creacion de carrito, Realización de pedidos, Busqueda de productos"
                    },
                    Link= "https://www.verdemercado.com.ar",
                    ImagenesURL = new List<string>
                    {
                        "/imagenes/VerdeMercado1.png",
                        "/imagenes/VerdeMercado2.png"
                    },
                    Id = 1
                },
                new ProyectoDTO
                {
                    Titulo = "NetChat",
                    Descripcion ="Clon de Slack realizado en ASP.NET Web API y React con fines educativos",
                    Tecnologias = new List<string>
                    {
                        "ASP.Net Web API",
                        "ASP.Net Core Identity",
                        "Entity Framework",
                        "SQLite",
                        "HTML",
                        "CSS",
                        "TypeScript",
                        "React",
                        "Axios",
                        "SignalR",
                        "Mobx",
                        "AutoMapper",
                        "Semantic UI",
                        "MediatR",
                        "JWT"
                    },
                    Funcionalidades = new List<string>
                    {
                        "Manejo de usuarios (Registro, Login)",
                        "Creación de salas de chat",
                        "Chat en salas de muchos usuarios simultaneos",
                        "Chat con usuarios individuales",
                        "Notificación de chats"
                    },
                    Link= "",
                    ImagenesURL = new List<string>
                    {
                        "/imagenes/NetChat1.png",
                        "/imagenes/NetChat2.png",
                        "/imagenes/NetChat3.png"
                    },
                    Id = 2
                }
            };
        }
    }
}
