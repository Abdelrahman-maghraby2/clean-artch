using Microsoft.Extensions.DependencyInjection;
using Restaurants.Application.Restaurants;
using Restaurants.Damain.Repositories;

namespace Restaurants.Application.Extentions;

public static class ServiceCollectionExtentions
{
    public static void AddApplication(this IServiceCollection services )
    {
       services.AddScoped<IRestaurantServes, RestaurantServes>();
    }
}