using Restaurants.Damain.Entities;

namespace Restaurants.Application.Restaurants
{
    public interface IRestaurantServes
    {
        Task<IEnumerable<Restaurant>> GetAllRestaurants();
    }
}