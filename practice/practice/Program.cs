using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {

        //practice one

        static void Swap()
        {
            Console.Write("Input the First Number :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Second Number :");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("After Swapping :");
            Console.WriteLine($"First Number :{y} ");
            Console.WriteLine($"Second Number :{x}");
            
        }

        static void Rearrange(string word)
        {
            string word2=word.Substring(word.Length - 1);
            string word3 = word.Substring(1,word.Length-2);
            string word4 = word.Substring(0, 1);

            //Console.WriteLine(word3);
            //Console.WriteLine(word2);
            //Console.WriteLine(word4);
            Console.WriteLine(word2+word3 + word4);
        }



        static void MyNumbers(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
        {
            double sum = a + b + c + d + e + f + g + h + i + j;
            double avg = sum / 10;

            Console.WriteLine("The sum of ten numbers is :" + sum);
            Console.WriteLine("The average is :" + avg);

        }
        static void Main(string[] args)
        {
            //Swap();
            //Rearrange("jackleen"); 

            //task1
            //Console.WriteLine(" Input the 10 numbers:");
            //Console.Write("Number-1 :");
            //int one = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Number-2 :");
            //int two = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Number-3 :");
            //int three = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Number-4 :");
            //int four = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Number-5 :");
            //int five = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Number-6 :");
            //int six = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Number-7 :");
            //int seven = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Number-8 :");
            //int eight = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Number-9 :");
            //int nine = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Number-10 :");
            //int ten = Convert.ToInt32(Console.ReadLine());


            //MyNumbers(one, two, three, four, five, six, seven, eight, nine, ten);
        }
    }
}
