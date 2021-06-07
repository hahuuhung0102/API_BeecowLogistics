using AutoMapper;
using BeecowLogistics.Services.DTOs.Login;
using BeecowLogistics.Services.DTOs.Station;
using BeecowLogistics.Services.Entities;

namespace BeecowLogistics.Services.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LoginModel, User>().ReverseMap();
            CreateMap<RegisterRequestModel, User>().ReverseMap();

            CreateMap<StationModel, Station>().ReverseMap();
        }
    }
}
