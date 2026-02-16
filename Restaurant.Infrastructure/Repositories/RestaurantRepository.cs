using Microsoft.EntityFrameworkCore;
using Restaurants.Damain.Entities;
using Restaurants.Damain.Repositories;
using Restaurants.Infrastructure.Persistence;

namespace Restaurants.Infrastructure.Repositories;

public class RestaurantRepository(RestaurantDbContext dbContext) : IRestaurantRepository
{
    public async Task<IEnumerable<Restaurant>> GetAllAsync()
    {
      var restaurants = await dbContext.Restaurants.ToListAsync();
        return restaurants;
    }
}
