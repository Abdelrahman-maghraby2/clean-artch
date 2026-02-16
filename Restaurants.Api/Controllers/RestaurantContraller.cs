using Microsoft.AspNetCore.Mvc;
using Restaurants.Application.Restaurants;

namespace Restaurants.Api.Controllers;

[ApiController]
[Route("api/restaurants")]
public class RestaurantContraller(IRestaurantServes restaurantServes) :ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    { 
        var restaurants =await restaurantServes.GetAllRestaurants();
        return Ok(restaurants);
    }
}
