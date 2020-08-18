using Br.Com.Restaurant.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Br.Com.Restaurant.Business.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<List<Restaurants>> GetAll(string name);

        Task<Restaurants> GetRestaurantById(string id);

        Task<Restaurants> Save(Restaurants model);

        Task<Restaurants> Update(string id, Restaurants model);

        Task<bool> Delete(string Id);
    }
}
