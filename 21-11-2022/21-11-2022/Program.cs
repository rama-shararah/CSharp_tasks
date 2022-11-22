using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number2);
            }


            //task2
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("The sign is: -");
            }
            else
            {
                Console.WriteLine("The sign is: +");
            }


            //task3
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num1 + "," + num2 + "," + num3);
                }
                else
                {
                    Console.WriteLine(num1 + "," + num3 + "," + num2);
                }
            }
            else if (num2 > num1 && num2 > num3)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num2 + "," + num1 + "," + num3);
                }
                else
                {
                    Console.WriteLine(num2 + "," + num3 + "," + num1);
                }
            }
            else if (num3 > num1 && num3 > num2)
            {
                if (num1 > num2)
                {
                    Console.WriteLine(num3 + "," + num1 + "," + num2);
                }
                else
                {
                    Console.WriteLine(num3 + "," + num2 + "," + num1);
                }
            }


            //task4
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine(b);
            }
            else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine(c);
            }
            else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine(d);
            }
            else if (e > a && e > b && e > c && e > d)
            {
                Console.WriteLine(e);
            }


            //task5
            double input = Convert.ToDouble(Console.ReadLine());
            double KMPH = input * 0.6214;
            Console.WriteLine(KMPH);



            //task6
            int hours = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());

            int hTom = hours * 60;
            int total = hTom + minutes;
            Console.WriteLine(total);


            //task7
            int min = Convert.ToInt32(Console.ReadLine());
            int mTOh = min / 60;
            int min1 = min % 60;
            Console.WriteLine(mTOh + " hours " + min1 + " minutes");



            //task8
            string[] arr = { "rama", "roa'a", "mohammed", "yazeed", "raghad", "mo'men" };
            Console.WriteLine(arr[0].Substring(0, 4));
            Console.WriteLine(arr[1].Substring(0, 4));
            Console.WriteLine(arr[2].Substring(0, 4));
            Console.WriteLine(arr[3].Substring(0, 4));
            Console.WriteLine(arr[4].Substring(0, 4));
            Console.WriteLine(arr[5].Substring(0, 4));

        }
    }
}
