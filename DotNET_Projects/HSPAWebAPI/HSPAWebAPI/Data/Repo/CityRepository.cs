using HSPAWebAPI.Interfaces;
using HSPAWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HSPAWebAPI.Data.Repo
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext db;
        public CityRepository(DataContext dc)
        {
            db = dc;
        }
        public void AddCity(City city)
        {
            db.Cities.AddAsync(city);
        }

        public void DeleteCity(int CityId)
        {
            var city = db.Cities.Find(CityId);
            db.Cities.Remove(city);
        }

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            return await db.Cities.ToListAsync();
        }
    }
}
