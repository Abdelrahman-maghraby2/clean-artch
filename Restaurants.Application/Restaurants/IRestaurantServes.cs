using Restaurants.Application.Restaurants.DTOs;
using Restaurants.Damain.Entities;

namespace Restaurants.Application.Restaurants
{
    public interface IRestaurantServes
    {
        Task<IEnumerable<RestaurantDto>> GetAllRestaurants();
        Task<RestaurantDto?> GetById(int id);

        Task<int> Create ( CreateRestaurantDto dto);
    }
}