using Microsoft.AspNetCore.Mvc;
using Restaurants.Application.Restaurants;
using Restaurants.Application.Restaurants.DTOs;

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
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    { 
        var restaurant = await restaurantServes.GetById(id);
        if (restaurant is null)
            return NotFound();
        return Ok(restaurant);

    }

    [HttpPost]
    public async Task<IActionResult> CreateRestaurant( CreateRestaurantDto createRestaurantDto)
    { 
        int id = await restaurantServes.Create(createRestaurantDto);
        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

}
