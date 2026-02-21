using Restaurants.Damain.Entities;
using Restaurants.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Infrastructure.Seeders;

public class RestaurantSeeder(RestaurantDbContext dbContext) : IRestaurantSeeder
{
    #region another way
    //private readonly RestaurantDbContext _dbContext;

    //public RestuarantSeeder(RestaurantDbContext dbContext)
    //{
    //   _dbContext = dbContext;
    //} 
    #endregion
    public async Task Seed()
    {
        if (await dbContext.Database.CanConnectAsync())
        {
            if (!dbContext.Restaurants.Any())
            {
                var restaurants = GetRestaurantS();
                dbContext.Restaurants.AddRange(restaurants);
                await dbContext.SaveChangesAsync();
            }
        }
    }

    private IEnumerable<Restaurant> GetRestaurantS()
    {

        List<Restaurant> restaurants = [
        new ()
        {
            Name = "KFC",
            Category = "Fast Food",
            Description = "Finger Lickin' Good!",
            ContactEmail = "contact@kfc.com",
            HasDelivery = true,
            Dishes=
            [
                new ()
                {
                    Name = "Chicken Bucket",
                    Price = 19.99M,
                    Description = "A bucket"
                },
                new ()
                {
                    Name = "Chicken Bucket",
                    Price = 19.99M,
                    Description = "A bucket"
                },
                new ()
                {
                    Name = "Chicken Bucket",
                    Price = 19.99M,
                    Description = "A bucket"
                }
            ],
            Address = new() { City = "London", Street = "123 High St", PostalCode = "SW1 1AA" }

        },
        new Restaurant()
        {
            Name = "Burger King",
            Category = "Fast Food",
            Description = "Taste is King",
            ContactEmail = "info@burgerking.com",
            HasDelivery = true,
            Address = new() { City = "Manchester", Street = "45 Main Road", PostalCode = "M1 1BE" },
                Dishes=
            [
                new ()
                {
                    Name = "Chicken Bucket",
                    Price = 19.99M,
                    Description = "A bucket"
                },
                new ()
                {
                    Name = "Chicken Bucket",
                    Price = 19.99M,
                    Description = "A bucket"
                }]
        }
        ];

        return restaurants;
    }



}
