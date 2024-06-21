using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt_2
{
    internal class Cars
    {
        private string ownerid;
        private string carid;
        private string engineid;
        private string bodyid;
        private string brand;
        private int price;
        private int year;
        public string OwenerID { get { return ownerid; } set { ownerid = value; } }
        public string CarID { get { return carid; } set { carid = value; } }
        public string EngineID { get { return engineid; } set { engineid = value; } }
        public string BodyID { get { return bodyid; } set { bodyid = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public int Price { get { return price; } set { price = value; } }
        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 2024)
                {
                    Console.WriteLine("The car is not made yet");
                }
                else
                {
                    year = value;
                }
            }
        }

        public Cars(string owenerID, string carID, string engineID, string bodyid, int price, int year)
        {
            this.ownerid = owenerID;
            this.carid = carID;
            this.engineid = engineID;
            this.bodyid = bodyid;
            this.brand = bodyid;
            this.price = price;
            this.year = year;
        }

        public Cars()
        {
        }

        public static void Print(List<Cars> list)
        {

            foreach (var item in list)
            {
                Console.WriteLine($"OwnerID:{item.OwenerID,-0}CardID:{item.CarID,-5}EngineID:{item.EngineID,-10}BodyID:{item.BodyID,-15}Brand:{item.Brand,-20}Price:{item.Price,-25}Year of manufactur{item.Year,-30}");
            }

        }
        public void Print1()
        {
            Console.WriteLine($"OwenerID:{this.OwenerID,-0}CarID:{this.CarID,-5}EngineID:{this.EngineID,-10}BodyID:{this.BodyID,-15}Brand:{this.Brand,-20}Price:{this.Price,-25}Year of manufactur:{this.Year,-30}");
        }
        public static void FindCarBrand(List<Cars> list)
        {
            Console.Write("On which car do you to have sprvaka:");
            string curbrand = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Brand == curbrand)
                {
                    list[i].Print1();
                }
            }
        }
        public static void FindCarByPrice(List<Cars> list)
        {
            Console.Write("On which car do you to have sprvaka by price:");
            int curprice = int.Parse(Console.ReadLine());
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Price == curprice)
                {
                    list[i].Print1();
                }
            }
        }
        public static void ActualicacionCar(List<Cars> list)
        {
            Console.Write("Do you want to update or delete the car info? (yes/no): ");
            string proceed = Console.ReadLine().ToLower();

            if (proceed == "YES")
            {
                Console.Write("Enter the car ID to update or delete: ");
                string carId = Console.ReadLine();
                Cars car = null;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].CarID == carId)
                    {
                        car = list[i];
                        break;
                    }
                }

                if (car != null)
                {
                    Console.Write("Enter 'UPD' to update or 'DEL' to delete the car: ");
                    string action = Console.ReadLine().ToUpper();

                    if (action == "UPD")
                    {
                        Console.Write("Enter new owner ID: ");
                        car.OwenerID = Console.ReadLine();
                        Console.Write("Enter new engine ID: ");
                        car.EngineID = Console.ReadLine();
                        Console.Write("Enter new body ID: ");
                        car.BodyID = Console.ReadLine();
                        Console.Write("Enter new brand: ");
                        car.Brand = Console.ReadLine();
                        Console.Write("Enter new price: ");
                        car.Price = int.Parse(Console.ReadLine());
                        Console.Write("Enter new year: ");
                        car.Year = int.Parse(Console.ReadLine());

                        Console.WriteLine("Car updated successfully.");
                    }
                    else if (action == "DEL")
                    {
                        list.Remove(car);
                        Console.WriteLine("Car deleted successfully.");
                    }

                }

            }
            else if (proceed == "NO")
            {
                Console.WriteLine("No action taken.");
            }

        }
        public static void DeleteCarByPrice(List<Cars> list)
        {
            Console.Write("Enter the brand of the car to delete: ");
            string deleteBrand = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Brand == deleteBrand)
                {

                    list.RemoveAt(i);
                }
            }
            Console.WriteLine($"Cars with brand {deleteBrand} have been deleted.");
        }
        public static void CalculateAge(List<Cars> list)
        {
            int totalAge = 0;
            int avrage = 0;
            for (int i = 0; i < list.Count; i++)
            {
                totalAge = totalAge + list[i].Year;
                avrage = totalAge / list.Count;
            }
            Console.WriteLine($"The sum age is{avrage} ");
        }
        public static void OldestCar(List<Cars> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("No cars in the system.");
                return;
            }

            Cars oldestCar = list[0];

            foreach (var car in list)
            {
                if (car.Year < oldestCar.Year)
                {
                    oldestCar = car;
                }
            }

            Console.WriteLine("Details of the oldest car:");
            oldestCar.Print1();
        }

    }
}