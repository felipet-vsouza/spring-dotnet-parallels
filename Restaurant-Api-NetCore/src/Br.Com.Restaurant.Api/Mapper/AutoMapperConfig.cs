using AutoMapper;
using Br.Com.Restaurant.Business.DTOs;
using Br.Com.Restaurant.Business.Models;

namespace Br.Com.Restaurant.Business.Mapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Restaurants, DTORestaurant>().ReverseMap();
            CreateMap<Address, DTOAddress>().ReverseMap();
            CreateMap<Grade, DTOGrade>().ReverseMap();
        }
    }
}
