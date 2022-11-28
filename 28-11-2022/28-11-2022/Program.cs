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

        public void engine(bool engine) {

            if (engine==true) {
                Console.WriteLine("you just start the engine");
            }

            if(engine==false)
            {
                Console.WriteLine("you just stop the engine");
            }
        
        }

        public int calculate(int k, int x)
        {
            
            return k * x;
        }

        public void fullInformation() {

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


            Car obj = new Car("Ford", 2020, "sedan", 25000, "mustang", 7154, "blue");
            Ford obj1 = new Ford("Ford", 2020, "sedan", 25000, "mustang", 7154, "blue");
            obj.fullInformation();
            obj1.fullInformation();
            obj1.engine(true);
            Console.WriteLine("Please enter how much Kilometer in one liter");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number of Liters you have");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number of Kilometer in " + y + " Liter = " + obj1.calculate(x, y));

            obj1.engine(false);
        }
    }
}
