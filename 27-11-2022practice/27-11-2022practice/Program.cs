

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using other_name_space;

namespace using_multiple_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////
            car myobj = new car();
            Console.WriteLine(myobj.Model);


            /// Class with method
            truck myobj2 = new truck();
            Console.WriteLine(myobj2.trucks());
            


            /// Different Name space
            other_name_space.rocket myobj3 = new other_name_space.rocket();

            Console.WriteLine(myobj3.Rocket);
            Console.WriteLine(myobj3.distance);
        }
    }

}