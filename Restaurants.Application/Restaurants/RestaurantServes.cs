
using AutoMapper;
using Microsoft.Extensions.Logging;
using Restaurants.Application.Restaurants.DTOs;
using Restaurants.Damain.Entities;
using Restaurants.Damain.Repositories;

namespace Restaurants.Application.Restaurants;

internal class RestaurantServes(IRestaurantRepository restaurantsRepository, ILogger<RestaurantServes> logger,IMapper 
    mapper) : IRestaurantServes
{
    public async Task<int> Create(CreateRestaurantDto dto)
    {
        logger.LogInformation("creating new restaurant");
            
       var restaurant = mapper.Map<Restaurant>(dto);    
        int id=await  restaurantsRepository.Create(restaurant); 
        return id;
    }

    public async Task<IEnumerable<RestaurantDto>> GetAllRestaurants()
    {
        logger.LogInformation("Getting all restaurants");
        var restaurants = await restaurantsRepository.GetAllAsync();

        #region last way 
        //var restaurantDto = restaurants.Select(r => new RestaurantDto
        //{
        //    Id = r.Id,
        //    Name = r.Name,
        //    Street = r.Address?.Street,
        //    City = r.Address?.City,
        //    PostalCode = r.Address?.PostalCode,
        //    Category = r.Category,
        //    Description = r.Description,
        //    HasDelivery = r.HasDelivery,
        //});
        //var restaurantDto = restaurants.Select(RestaurantDto.FromEntity);

        #endregion

        var restaurantDto =  mapper.Map<IEnumerable<RestaurantDto>>(restaurants);
        return restaurantDto! ;
    }

    public async Task<RestaurantDto?> GetById(int id)
    {
        logger.LogInformation($"Getting  restaurants with {id}");

        var restaurant = await restaurantsRepository.GetByIdAsync(id);

        var restaurantDto = mapper.Map<RestaurantDto?>(restaurant);
        return restaurantDto;
    }
}
