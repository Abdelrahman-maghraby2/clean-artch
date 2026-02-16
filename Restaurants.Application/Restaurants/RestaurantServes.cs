
using Microsoft.Extensions.Logging;
using Restaurants.Damain.Entities;
using Restaurants.Damain.Repositories;

namespace Restaurants.Application.Restaurants;

internal class RestaurantServes(IRestaurantRepository restaurantsRepository, ILogger<RestaurantServes> logger) : IRestaurantServes
{
    public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
    {
        logger.LogInformation("Getting all restaurants");
        var restaurants = await restaurantsRepository.GetAllAsync();
        return restaurants;
    }
}
