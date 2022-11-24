using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _23_11_2022
{
    internal class Program
    {
        static void task1()
        {
            Console.WriteLine("...........................Task 1........................");
            Console.WriteLine("Enter 10 numbers");
            double sum = 0;
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"Number-{i} :");
                int num=Convert.ToInt32( Console.ReadLine() );
                sum+=num;
            }   
            double avg=sum/10;
            Console.WriteLine("The sum of 10 no is :" + sum);
            Console.WriteLine("The Average is : "+avg);

        }


        //task2 
        static void task2() {

            Console.WriteLine("...........................Task 2........................");
            Console.WriteLine("Enter 5 numbers");
            for (int i = 0; i < 5; i++)
            {
                int nm = Convert.ToInt32(Console.ReadLine());
                int cube = nm * nm * nm;
                Console.WriteLine($"Number is :{nm} and cube of the {nm} is :{cube} ");
            }
            
        }


        //task3
        static void task3(int[] years)
        {
            Console.WriteLine("...........................Task 3........................");
            for (int i = 0; i < years.Length; i++)
            {
                if (years[i] > 1950)
                {
                    Console.WriteLine(years[i]);
                }
            }
        }

        //task4
        static void task4()
        {
            Console.WriteLine("...........................Task 4........................");
            Console.Write("Plz Enter your age :");
            int x=Convert.ToInt32(Console.ReadLine());
            int days= x*365;
            Console.WriteLine($"Your age in days is :{days}");
        }


        //task5

        static int Task5Animals(int chickens, int cows, int pigs)
        {
            Console.WriteLine("...........................Task 5........................");
            int legs = (chickens*2) + (cows*4) + (pigs*4);
            return legs;

        }
        


        //task6

        static void Task6Login(string username, int password )
        {
            Console.WriteLine("...........................Task 6........................");
            string[] user = { "rama","aram","shahd"};
            int[] pass = { 1234,6363,5555 };
            
            
                if (user[0] == username && pass[0]==password || user[1] == username && pass[1] == password || user[2] == username && pass[2] == password)
                {
                    Console.WriteLine("success login");
                    
                }
                else
                {
                    Console.WriteLine("faild");
                    
                }
            
        }


 
        //static void task7() { 
        //    Console.WriteLine("calc the power of numbers :");

        //    Console.Write(" Input the number : ");
        //    int x = Convert.ToInt32(Console.ReadLine());

        //    Console.Write(" Input the exponent : ");
        //    int y = Convert.ToInt32(Console.ReadLine());

        //    if (y == 0)
        //        Console.WriteLine($" The number{x} to the power of {0} is : {1}");
        //    else
        //    {
        //        int power = x*(x*(y-1));
        //        Console.WriteLine($" The number{x} to the power of {y} is : {power}");
        //    }
                
        //}


        static void task7()
        {
            Console.WriteLine("...........................Task 7........................");
            Console.WriteLine("calc the power of numbers :");

            Console.Write(" Input the number : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input the exponent : ");
            int y = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            while (y != 0)
            {
                result = result * x;
                y--;

            }
            
            Console.WriteLine($" The result: {result}");
        }


        static void task8()
        {
            Console.WriteLine("...........................Task 8........................");
            for (int i = 1900; i < 2024; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }


        static string task9()
        {
            Console.WriteLine("...........................Task 9........................");
            Console.Write("Enter the Number to check Prime: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return "not prime";
                    
                }  
            }
            return "prime";
        }

 

        //static void task10()
        //{
        //    Console.Write("Enter a  sentence :");
        //    string sen = Console.ReadLine();
        //    int sum = 0;
        //    foreach(char i in sen)
        //    {
        //        if (i == ' ')
        //        {
        //            sum += 1;
        //        }
        //    }
        //    int words=sum + 1;
        //    Console.WriteLine($"The number of words is :{words}");
        //}


        static void task10()
        {
            Console.WriteLine("...........................Task 10........................");
            Console.Write("Enter a  sentence :");
            string sen = Console.ReadLine();
            string[] sen2 = sen.Split(' ');
            Console.WriteLine(sen2.Length);

            

        }



        static void Main(string[] args)
        {

            task1();
            task2();
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            task3(years);
            task4();
            Console.WriteLine("total legs :" + Task5Animals(1, 3, 5));
            Task6Login("aram", 6363);
            task7();
            task8();
            Console.WriteLine(task9());
            task10();
        }
    }
}
