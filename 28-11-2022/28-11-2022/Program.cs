using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _28_11_2022
{

    class Car
    {
       public string Make { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }
        public int Pallet_No { get; set; }
        public string Color { get; set; }

        public Car(string make, int year, string type, double price, string model, int pallet_No, string color)
        {
            Make = make;
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            Pallet_No = pallet_No;
            Color = color;
        }
        public Car() { }

        public void engine() {

            Console.WriteLine("start/stop the engine?");
            string x = Console.ReadLine();
            if (x=="start" || x=="Start") {
                Console.WriteLine("The engine has been started");
            }

            if(x=="stop" || x=="Stop")
            {
                Console.WriteLine("The engine has been stopped");
            }
        
        }
        protected int KM = 20;
        public void calculate(int lr)
        {
            
            int KM_L= KM * lr;
            Console.WriteLine($"The car will wake {KM_L} kilometers ");
        }

        public void fullInformation() {
            Console.WriteLine("your car information :");
            Console.WriteLine("car make :" + Make);
            Console.WriteLine("car year :" + Year);
            Console.WriteLine("car type :" + Type);
            Console.WriteLine("car price :" + Price);
            Console.WriteLine("car model :" + Model);
            Console.WriteLine("car pallet-no :" + Pallet_No);
            Console.WriteLine("car color :" + Color);
        }
    }

    class Ford:Car
    {
        //:base(make, year, type, price, model, pallet_No, color)
        public Ford(string make, int year, string type, double price, string model, int pallet_No, string color)
        {
            Make = make;
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            Pallet_No = pallet_No;
            Color = color;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {


            Car car = new Car("Ford", 2018, "sedan", 25000, "mustang", 8888, "black");
            Ford car2 = new Ford("Ford", 2020, "sedan", 28000, "mustang", 7154, "blue");
            car.fullInformation();
            car2.fullInformation();
            car2.engine();
            car2.calculate(2);
            car2.engine();
        }
    }
}
