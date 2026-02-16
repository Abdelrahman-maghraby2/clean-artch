using Restaurants.Damain.Entities;

namespace Restaurants.Damain.Repositories;

public interface IRestaurantRepository
{
    Task<IEnumerable<Restaurant>> GetAllAsync();
}
