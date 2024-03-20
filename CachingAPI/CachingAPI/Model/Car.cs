using CachingAPI.Model.contracts;

namespace CachingAPI.Model
{
    public class Car :  entityBase
    {
        public string Name { get; private set; }
        public string Model { get; private set; }
        public string Brand { get; private set; }
        public int Year { get; private set; }

        public Car(){}

        public void Update(string name,
                           string model,
                           string brand,
                           int year)
        {
            Name = name;
            Model = model;
            Brand = brand;
            Year = year;
        }

        public Car(string name, 
                    string model, 
                    string brand, 
                    int year)
        {
            Name = name;
            Model = model;
            Brand = brand;
            Year = year;
        }
    }
}
