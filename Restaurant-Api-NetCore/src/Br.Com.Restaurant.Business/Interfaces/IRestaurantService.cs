using Br.Com.Restaurant.Business.DTOs;
using Br.Com.Restaurant.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Br.Com.Restaurant.Business.Interfaces
{
    public interface IRestaurantService
    {
        Task<Restaurants> GetRestaurantById(string id);

        Task<List<Restaurants>> GetRestaurants(string name);

        Task<Restaurants> Save(Restaurants dto);

        Task<Restaurants> Update(string id, Restaurants dto);

        Task<bool> Delete(string id); 
    }
}
