using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace using_multiple_classes
{
    class car
    {

        public string Model = "Audi";

    }
}

class truck
{
    public string owner;
   
    public string trucks()
    {
        owner = "Yazeed";
        return owner;
        
    }
}