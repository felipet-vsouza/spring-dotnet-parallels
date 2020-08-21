using Bogus;
using Br.Com.Restaurant.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Br.Com.Restaurant.Tests
{

    [CollectionDefinition(nameof(RestaurantCollection))]
    public class RestaurantCollection : ICollectionFixture<RestaurantTestsFixture>
    { }

    public class RestaurantTestsFixture : IDisposable
    {
        public Task<List<Restaurants>> GenerateRestaurants(int quantity)
        {
            var restaurants = new Faker<Restaurants>("pt_BR")
                .CustomInstantiator(f => new Restaurants(
                    
            //TODO: Implementar criação de dados fake do restaurante 
                
            ));

            return Task.FromResult(restaurants.Generate(quantity));
        }

        public Task<Restaurants> GenerateRestaurant(string objectId)
        {
            var restaurant = new Faker<Restaurants>("pt_BR")
                .CustomInstantiator(f => new Restaurants(

            //TODO: Implementar criação de dados fake do restaurante 

            ));

            return Task.FromResult(restaurant.Generate(1).FirstOrDefault());
        }

        public void Dispose()
        {
        }
    }
}
