using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
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
        }
    }
}
