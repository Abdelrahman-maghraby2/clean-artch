using Microsoft.EntityFrameworkCore;
using Restaurants.Damain.Entities;
using Restaurants.Damain.Repositories;
using Restaurants.Infrastructure.Persistence;
using System.Data;

namespace Restaurants.Infrastructure.Repositories;

public class RestaurantRepository(RestaurantDbContext dbContext) : IRestaurantRepository
{
    public async Task<int> Create(Restaurant entity)
    {
      dbContext.Restaurants.Add(entity);
        await dbContext.SaveChangesAsync();
        return entity.Id;
    }

    public async Task<IEnumerable<Restaurant>> GetAllAsync()
    {
      var restaurants = await dbContext.Restaurants.ToListAsync();
        return restaurants;
    }

    public async Task<Restaurant?> GetByIdAsync(int id)
    {
       var restaurant =await dbContext.Restaurants
            .Include(r=>r.Dishes)
            .FirstOrDefaultAsync(r => r.Id == id);
        return restaurant;
    }
}
