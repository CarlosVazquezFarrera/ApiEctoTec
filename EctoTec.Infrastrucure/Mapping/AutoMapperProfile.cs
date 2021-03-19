namespace EctoTec.Infrastrucure.Mapping
{
    using AutoMapper;
    using EctoTect.Core.DTOs;
    using EctoTect.Core.Entities;

    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<UsuarioDTO, Usuario>();

            CreateMap<Ciudad, CiudadDTO>();
            CreateMap<CiudadDTO, Ciudad>();

            CreateMap<Entidad, EntidadDTO>();
            CreateMap<EntidadDTO, Entidad>();

            CreateMap<Pais, PaisDTO>();
            CreateMap<PaisDTO, Pais>();


        }
    }
}
