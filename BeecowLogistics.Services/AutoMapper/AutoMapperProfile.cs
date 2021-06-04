using AutoMapper;
using BeecowLogistics.Services.DTOs.Login;
using BeecowLogistics.Services.Entities;

namespace BeecowLogistics.Services.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LoginModel, Users>().ReverseMap();
        }
    }
}
