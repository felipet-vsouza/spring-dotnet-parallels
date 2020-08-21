using Br.Com.Restaurant.Business.Interfaces;
using Br.Com.Restaurant.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Br.Com.Restaurant.Business.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository restaurantRepository;
      
        public RestaurantService(IRestaurantRepository pRestaurantRepository)
        {
            restaurantRepository = pRestaurantRepository;
        }

        public async Task<bool> Delete(string id)
        {
            var result = await restaurantRepository.Delete(id);

            return result;
        }

        public async Task<Restaurants> GetRestaurantById(string id)
        {
            return await restaurantRepository.GetRestaurantById(id);
        }

        public async Task<List<Restaurants>> GetRestaurants(string name)
        {
            return await restaurantRepository.GetAll(name);
        }

        public async Task<Restaurants> Save(Restaurants model)
        {
            return await restaurantRepository.Save(model);
        }

        public async Task<Restaurants> Update(string id, Restaurants model)
        {
            return await restaurantRepository.Update(id, model);
        }
    }
}
