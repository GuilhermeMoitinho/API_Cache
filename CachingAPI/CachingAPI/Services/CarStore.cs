using Bogus;
using CachingAPI.Model;
using CachingAPI.Model.DTOs;
using CachingAPI.Services.interfaces;

namespace CachingAPI.Services
{
    public class CarStore : ICarStore
    {
        public List<Car> CarsStorage { get; set; }

        public CarStore()
        {
            var testOrders = new Faker<Car>()
                .RuleFor(o => o.Id, f => Guid.NewGuid())
                .RuleFor(o => o.Year, f => f.Random.Int(1950, 2020))
                .RuleFor(o => o.Brand, f => f.Vehicle.Manufacturer())
                .RuleFor(o => o.Model, f => f.Vehicle.Model());
            CarsStorage = testOrders.Generate(10);
        }

        public CarsDTO List()
        {
            return new CarsDTO("Database", CarsStorage.ToList());
        }
    }
}
