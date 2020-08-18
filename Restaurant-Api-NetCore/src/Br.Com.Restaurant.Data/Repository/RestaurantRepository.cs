using Br.Com.Restaurant.Business.Interfaces;
using Br.Com.Restaurant.Business.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Br.Com.Restaurant.Data.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly IMongoCollection<Restaurants> restaurants;

        private readonly IConfiguration Config;

        public RestaurantRepository(IConfiguration config)
        {
            Config = config;

            var client = new MongoClient(Config.GetConnectionString("ConnectionString"));
            var database = client.GetDatabase(Config.GetConnectionString("DatabaseName"));

            restaurants = database.GetCollection<Restaurants>("restaurants");
        }

        public async Task<bool> Delete(string id)
        {
            var result = await restaurants.DeleteOneAsync(book => book.id == id);

            return true;
        }

        public async Task<List<Restaurants>> GetAll(string name)
        {
            return await restaurants.Find(r => true).ToListAsync();
        }

        public async Task<Restaurants> GetRestaurantById(string id)
        {
            return await restaurants.Find<Restaurants>(r => r.id == id).FirstOrDefaultAsync();
        }

        public async Task<Restaurants> Save(Restaurants model)
        {
            await restaurants.InsertOneAsync(model);
            return model;
        }

        public async Task<Restaurants> Update(string id, Restaurants model)
        {
            await restaurants.ReplaceOneAsync(r => r.id == id, model);
            return model;
        }
    }
}
