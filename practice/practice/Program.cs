using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void MyNumbers(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
        {
            double sum = a + b + c + d + e + f + g + h + i + j;
            double avg = sum / 10;

            Console.WriteLine("The sum of ten numbers is :" + sum);
            Console.WriteLine("The average is :" + avg);

        }
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string x in cars)
            {

                Console.WriteLine(x);

                if (x == cars[2])
                {
                    break;
                }

            }


            //task1
            Console.WriteLine(" Input the 10 numbers:");
            Console.Write("Number-1 :");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-2 :");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-3 :");
            int three = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-4 :");
            int four = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-5 :");
            int five = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-6 :");
            int six = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-7 :");
            int seven = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-8 :");
            int eight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-9 :");
            int nine = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number-10 :");
            int ten = Convert.ToInt32(Console.ReadLine());


            MyNumbers(one, two, three, four, five, six, seven, eight, nine, ten);
        }
    }
}
