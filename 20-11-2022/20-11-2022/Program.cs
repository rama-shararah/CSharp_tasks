using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            String x;
            x = Console.ReadLine();
            Console.WriteLine(x);


            //task2
            string name = "rama";
            int age = 22;
            double salary = 850.5;
            char name_first_letter = 'R';
            bool MyBool = true;
            const double pie = 3.14;
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(salary);
            Console.WriteLine(name_first_letter);
            Console.WriteLine(MyBool);
            Console.WriteLine(pie);


            //task3
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);
            Console.WriteLine(cars.Length);




            //task4
            Console.WriteLine("Input your firstname:");
            string fName = Console.ReadLine();
            Console.WriteLine("Input your lastname:");
            string lName = Console.ReadLine();
            Console.WriteLine("Input your year of birth:");
            string year = Console.ReadLine();

            Console.Write(fName + " ");
            Console.Write(lName + " ");
            Console.WriteLine(year);



            //task5
            int[] arr = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("Elements in array are: ");
            Console.Write(arr[0]);
            Console.Write(arr[1]);
            Console.Write(arr[2]);
            Console.Write(arr[3]);
            Console.Write(arr[4]);
            Console.Write(arr[5]);
            Console.Write(arr[6]);
            Console.Write(arr[7]);
            Console.Write(arr[8]);
            Console.WriteLine(arr[9]);


            //task6
            int[] myarr = { 5, 5, 10 };
            int sum = myarr[0] + myarr[1] + myarr[2];
            Console.WriteLine("Sum of all elements stored in the array is : " + sum);



        }
    }
}
