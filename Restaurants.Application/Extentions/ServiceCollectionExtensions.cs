using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Restaurants.Application.Restaurants;
using Restaurants.Application.Restaurants.Validators;
using Restaurants.Damain.Repositories;

namespace Restaurants.Application.Extentions;

public static class ServiceCollectionExtentions
{
    public static void AddApplication(this IServiceCollection services )
    {
       services.AddScoped<IRestaurantServes, RestaurantServes>();

      services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        services.AddValidatorsFromAssembly(typeof(ServiceCollectionExtentions).Assembly)
            .AddFluentValidationAutoValidation(); 
        //services.AddValidatorsFromAssembly(typeof(CreateRestaurantDtoValidator).Assembly);
    }
}