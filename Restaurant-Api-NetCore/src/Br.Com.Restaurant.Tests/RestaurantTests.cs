using Br.Com.Restaurant.Business.Interfaces;
using Br.Com.Restaurant.Business.Services;
using Moq;
using System.Linq;
using Xunit;

namespace Br.Com.Restaurant.Tests
{
    [Collection(nameof(RestaurantCollection))]
    public class RestaurantTests
    {
        private readonly RestaurantTestsFixture _restaurantTestsFixture;

        public RestaurantTests(RestaurantTestsFixture restaurantTestsFixture)
        {
            _restaurantTestsFixture = restaurantTestsFixture;
        }

        [Fact(DisplayName = "Must return restaurants")]
        [Trait("Category", "Restaurant")]
        public async void Restaurant_GetRestaurants_MustReturnRestaurants()
        {
            //Arrange
            var restaurantRepository = new Mock<IRestaurantRepository>();
            var restaurantService = new RestaurantService(restaurantRepository.Object);

            restaurantRepository.Setup(f => f.GetAll("nome")).Returns(_restaurantTestsFixture.GenerateRestaurants(100));

            //Act
            var restaurants = await restaurantService.GetRestaurants("");

            //Assert
            restaurantRepository.Verify(f => f.GetAll("nome"), Times.Once);
            Assert.True(restaurants.Any());
        }

        [Fact(DisplayName = "Must return restaurant")]
        [Trait("Category", "Restaurant")]
        public async void Restaurant_GetRestaurantById_MustReturnRestaurant()
        {
            //Arrange
            var restaurantRepository = new Mock<IRestaurantRepository>();
            var restaurantService = new RestaurantService(restaurantRepository.Object);

            restaurantRepository.Setup(f => f.GetRestaurantById("123")).Returns(_restaurantTestsFixture.GenerateRestaurant("123"));

            //Act
            var restaurant = await restaurantService.GetRestaurants("123");

            //Assert
            restaurantRepository.Verify(f => f.GetRestaurantById("123"), Times.Once);
            Assert.True(restaurant != null);
        }

    }
}
