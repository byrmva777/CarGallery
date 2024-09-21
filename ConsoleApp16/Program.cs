using ConsoleApp16;

class Program
{
    static void Main(string[] args)
    {
        CarGallery gallery = new CarGallery { Name = "Rubab's Gallery" };

        gallery.AddCar(new Car { Id = 1, Marka = "Mercedes", Model = "Maybach", Year = 2024 });
        gallery.AddCar(new Car { Id = 2, Marka = "Mercedes", Model = "S-450", Year = 2024 });

        gallery.GetAllCars();

        gallery.SaveToJson("cars.json");

        Console.WriteLine(" Saved to cars.json");
    }
}