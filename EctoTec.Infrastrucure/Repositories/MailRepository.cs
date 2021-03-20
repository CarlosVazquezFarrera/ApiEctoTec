namespace EctoTec.Infrastrucure.Repositories
{
    using EctoTec.Infrastrucure.Config;
    using EctoTect.Core.CustomEntites;
    using EctoTect.Core.Entities;
    using EctoTect.Core.Interfaces.Repository;
    using System;
    using System.Net;
    using System.Net.Mail;
    using System.Text;
    using System.Threading.Tasks;

    public class MailRepository : IMailRepository
    {
        public async Task<BasicResponse> EnviarMail(Usuario usuario)
        {
            BasicResponse mailResponse = new BasicResponse();

            MailMessage mail = new MailMessage();
            mail.To.Add(usuario.Mail);
            //mail.To.Add("Another Email ID where you wanna send same email");
            mail.From = new MailAddress(Configuracion.CurrentValues.Mail, "Green Leaves");
            mail.Subject = "Registro exitoso";
            mail.Body = $"<h1>Gracias</h1>"+
                $"<p>Estimado {usuario.Nombre}, su registro en la plataforma ha sido exitoso. Gracias por la preferencia.</p>" +
                $"<p>AtentaMente: <strong>El equipo de Green Leaves</strong></p>";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = Configuracion.CurrentValues.Servidor; 
            smtp.Credentials = new NetworkCredential(Configuracion.CurrentValues.Mail, Configuracion.CurrentValues.PasswordCorreo);
            smtp.EnableSsl = true;
            smtp.Port = 587;
            try
            {
                await smtp.SendMailAsync(mail);
                mailResponse.Exito = true;
                mailResponse.Mensaje = "Correo enviado con éxito";

            }
            catch (Exception ex)
            {
                mailResponse.Mensaje = "Error al enviar correo";
            }
            return mailResponse;
        }
    }
}
