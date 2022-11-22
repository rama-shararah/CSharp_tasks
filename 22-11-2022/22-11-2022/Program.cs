using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1

            //string[] ARR = [1, 7  9  45, ]
            //int arr2 =["Str" "alex", "moh"
            //string arr3 = 'the', 'fox' 'over' lazy, 'dog',  ]

            //int[] ARR = { 1, 7, 9, 45 };
            //string[] arr2 = { "Str", "alex", "moh" };
            //string[] arr3 = { "the", "fox" ,"over", "lazy", "dog", };



            //task2
            //string[] fruits = { "Tomato", "Banana", "Watermelon" };
            //Console.WriteLine(Array.IndexOf(fruits,"Tomato"));
            //Console.WriteLine(Array.IndexOf(fruits, "Banana"));


            //task3
            //string[] FavoriteFood = { "pizza", "konafa", "pasta", "orange cake", "mango" };
            //foreach(string i in FavoriteFood)
            //{
            //    Console.WriteLine(i);
            //}
            //string[] FavoriteSport = { "Tennis", "yoga", "basketball" };
            //for(int x=0;x< FavoriteSport.Length; x++)
            //{
            //    Console.WriteLine(FavoriteSport[x]);
            //}

            //string[] FavoriteMovie = { "Thor", "Howls moving castle", "violet Evergarden", "Spiderman" };
            //foreach (string y in FavoriteMovie)
            //{
            //    Console.WriteLine(y);
            //}


            //task4
            //string numbers = (Console.ReadLine());

            //string[] arr = numbers.Split(',');
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += Convert.ToInt32(arr[i]);
            //}
            //Console.WriteLine("The sum of three numbers: " + sum);


            //task5
            //int sm = 0;
            //Console.Write("The odd numbers are: ");
            //for (int i = 0; i <=100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sm += i;
            //        Console.Write(" ");
            //        Console.Write(i);
            //    }

            //}
            //Console.WriteLine(" ");
            //Console.WriteLine("The Sum of odd Numbers is: "+sm);



            //task6



            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int x = 1; x <= i; x++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}


            //task7

            int r = 1;
            for (int i = 1; i <=4; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(r+" ");
                    r++;
                }
                Console.WriteLine();
            }

        }
    }
}
