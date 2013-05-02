using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6SubclassConstructorExample
{
    class MySubclass : MyBaseClass
    {
        public MySubclass(string baseClassNeedsThis, int anotherValue) : base(baseClassNeedsThis)
        {
            Console.WriteLine("This is the subclass: " + baseClassNeedsThis + " and " + anotherValue);
        }
    }
}
