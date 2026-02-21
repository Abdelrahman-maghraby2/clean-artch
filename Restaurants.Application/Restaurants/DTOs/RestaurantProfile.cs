
using AutoMapper;
using Restaurants.Damain.Entities;

namespace Restaurants.Application.Restaurants.DTOs;

public class RestaurantProfile:Profile
{
    public RestaurantProfile()
    {
        CreateMap<CreateRestaurantDto,Restaurant>()
            .ForMember(d => d.Address, opt => opt.MapFrom(src => new Address()
            {
                Street = src.Street,
                City = src.City,
                PostalCode = src.PostalCode
            }));
        CreateMap<Restaurant, RestaurantDto>()
                 .ForMember(d => d.Street, opt => opt.MapFrom(src =>  src.Address!.Street))
                 .ForMember(d => d.City, opt => opt.MapFrom(src =>  src.Address!.City))
                 .ForMember(d => d.PostalCode, opt => opt.MapFrom(src =>  src.Address!.PostalCode))
                 .ForMember(d => d.Dishes, opt => opt.MapFrom(src => src.Dishes));
    }
}
