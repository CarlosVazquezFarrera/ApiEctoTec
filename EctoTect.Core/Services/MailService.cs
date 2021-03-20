namespace EctoTect.Core.Services
{
    using AutoMapper;
    using EctoTect.Core.CustomEntites;
    using EctoTect.Core.DTOs;
    using EctoTect.Core.Entities;
    using EctoTect.Core.Interfaces.Repository;
    using EctoTect.Core.Interfaces.Service;
    using System.Threading.Tasks;
    public class MailService : IMailService
    {
        public MailService(IMailRepository mailRepository, IMapper mapper)
        {
            this._mailRepository = mailRepository;
            this._mapper = mapper;
        }

        private IMailRepository _mailRepository;
        private IMapper _mapper;
        public async Task<BasicResponse> EnviarMail(UsuarioDTO usuario)
        {
            if (string.IsNullOrEmpty(usuario.Mail) || string.IsNullOrWhiteSpace(usuario.Mail))
                return new BasicResponse { Exito = false, Mensaje = "Debe enviar un correo"};
            
            return  await _mailRepository.EnviarMail(_mapper.Map<Usuario>(usuario));
        }
    }
}
