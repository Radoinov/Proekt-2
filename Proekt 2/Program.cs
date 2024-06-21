namespace Proekt_2
{
    internal class Program
    {
        static List<Cars> list = new List<Cars>();
        static void Main(string[] args)
        {
            Console.Write("How many cars do you want:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Cars car = new Cars();
                Console.Write("What is the owners id:");
                string owner = Console.ReadLine();
                car.OwenerID = owner;
                Console.Write("What is the car id:");
                string carID = Console.ReadLine();
                car.CarID = carID;
                Console.Write("What is the engine id:");
                string bodyID = Console.ReadLine();
                car.BodyID = bodyID;
                Console.Write("What is the car brand:");
                string brand = Console.ReadLine();
                car.Brand = brand;
                Console.Write("What is the car price:");
                int price = int.Parse(Console.ReadLine());
                car.Price = price;
                Console.Write("what is the year of manufactur:");
                int year = int.Parse(Console.ReadLine());
                car.Year = year;
                list.Add(car);

            }
            Cars.Print(list);
            Cars.FindCarBrand(list);
            Cars.FindCarByPrice(list);
            Cars.ActualicacionCar(list);
            Cars.DeleteCarByPrice(list);
            Cars.CalculateAge(list);
            Cars.OldestCar(list);


        }
    }
}
