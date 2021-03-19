namespace EctoTect.Core.Interfaces.Service
{
    public interface IMailService
    {
        /// <summary>
        /// Ejecuta el método que envía el correo al usuario
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        bool EnviarMail(string mail);
    }
}
