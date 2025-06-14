using AutoMapper;
using Repository.Models;
using Services.DTOs;

namespace Services.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AngularUsersDTO, AngularUsers>().ReverseMap();
        }   
    }
}
