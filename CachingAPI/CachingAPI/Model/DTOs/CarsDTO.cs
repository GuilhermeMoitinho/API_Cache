using Bogus;

namespace CachingAPI.Model.DTOs
{
    public class CarsDTO
    {
        public List<Car> Cars { get; set; }
        public Car Car { get; set; }
        public string From { get; set; }

        public CarsDTO(string from, List<Car> cars)
        {
            Cars = cars.ToList();
            From = from;
        }

        public void FromMemomy()
        {
            From = "From memory";
        }
    }
}
