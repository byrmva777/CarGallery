using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class CarGallery
    {
        public string Name { get; set; }
        public List<Car> Cars { get; set; } = new List<Car>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void RemoveCar(int carId)
        {
            Cars.RemoveAll(c => c.Id == carId);
        }

        public void GetAllCars()
        {
            foreach (var car in Cars)
            {
                Console.WriteLine(car);
            }
        }

        public Car GetById(int carId)
        {
            return Cars.Find(c => c.Id == carId);
        }

        public void SaveToJson(string filePath)
        {
            JsonSerializerOptions op = new JsonSerializerOptions();
            op.WriteIndented = true;
            Console.WriteLine(JsonSerializer.Serialize(Cars, op));
            var jsonString = JsonSerializer.Serialize(Cars, op);
            File.WriteAllText("cars.json", jsonString);
        }
    }
}
