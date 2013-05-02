using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6SubclassConstructorExample
{
    class MyBaseClass
    {
        public MyBaseClass(string baseClassNeedsThis)
        {
            Console.WriteLine("This is the base class: " + baseClassNeedsThis);
        }
    }
}
