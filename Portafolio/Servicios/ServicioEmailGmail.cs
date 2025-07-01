﻿using Portafolio.Models;
using System.Net;
using System.Net.Mail;

namespace Portafolio.Servicios
{
    public interface IServicioEmail
    {
        Task Enviar(ContactoDTO contacto);
    }

    public class ServicioEmailGmail : IServicioEmail
    {
        private readonly IConfiguration config;

        public ServicioEmailGmail(IConfiguration config)
        {
            this.config = config;
        }

        public async Task Enviar(ContactoDTO contacto)
        {
            var emailEmisor = config.GetValue<string>("CONFIGURACIONES_EMAIL:EMAIL");
            var password = config.GetValue<string>("CONFIGURACIONES_EMAIL:PASSWORD");
            var host = config.GetValue<string>("CONFIGURACIONES_EMAIL:HOST");
            var puerto = config.GetValue<int>("CONFIGURACIONES_EMAIL:PUERTO");

            var smtpCliente = new SmtpClient(host, puerto);
            smtpCliente.EnableSsl = true;
            smtpCliente.UseDefaultCredentials = false;
            smtpCliente.Credentials = new NetworkCredential(emailEmisor, password);
            var mensaje = new MailMessage(emailEmisor, emailEmisor, $"El cliente {contacto.Nombre} ({contacto.Email}) quiere contactarte", contacto.Mensaje);

            await smtpCliente.SendMailAsync(mensaje);
        }
    }
}
