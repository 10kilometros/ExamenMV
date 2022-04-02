using AutoMapper;
using Examen.Caso3.Application.Dtos;
using Examen.Caso3.Domain.Aggregates.ClienteAgg;

namespace Examen.Caso3.Application.MapperProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Entity to Dto

            CreateMap<Cliente, ClienteDto>()
                .ForPath(x => x.ApellidosCompletos, y => y.MapFrom(z => z.Apellidos ?? ""));

            #endregion

            #region Dto to Entity

            CreateMap<ClienteDto, Cliente>()
                .ForPath(x => x.Apellidos, y => y.MapFrom(z => z.ApellidosCompletos ?? ""));

            #endregion
        }
    }
}
