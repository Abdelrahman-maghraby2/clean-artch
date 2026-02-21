

using Restaurants.Application.Dishes.Dtos;
using Restaurants.Damain.Entities;

namespace Restaurants.Application.Restaurants.DTOs;

public class RestaurantDto
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Category { get; set; } = default!; 
    public bool HasDelivery { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public string? PostalCode { get; set; }
    public List<DishDto> Dishes { get; set; } = new();

    //public static RestaurantDto? FromEntity(Restaurant? restaurant)
    //{
    //    if(restaurant is null)
    //    {
    //        return null;
    //    }
    //    return new RestaurantDto()
    //    {
    //        Id = restaurant.Id,
    //        Name = restaurant.Name,
    //        Street = restaurant.Address?.Street,
    //        City = restaurant.Address?.City,
    //        PostalCode = restaurant.Address?.PostalCode,
    //        Category = restaurant.Category,
    //        Description = restaurant.Description,
    //        HasDelivery = restaurant.HasDelivery,
    //       Dishes= restaurant.Dishes.Select(DishDto.FromEntity).ToList()
    //    };
    //}
}
