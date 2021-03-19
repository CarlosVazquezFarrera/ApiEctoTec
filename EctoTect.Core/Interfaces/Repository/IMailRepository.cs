namespace EctoTect.Core.Interfaces.Repository
{
    public interface IMailRepository
    {
        /// <summary>
        /// Envía el mail al usuario
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        bool EnviarMail(string mail);
    }
}
