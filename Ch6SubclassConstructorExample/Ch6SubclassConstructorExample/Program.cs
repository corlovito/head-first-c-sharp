using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6SubclassConstructorExample
{
    class Program
    {
        static void Main(string[] args)
        {
         //   MyBaseClass baseClass = new MyBaseClass("Hey Hey!");
            MySubclass subclass = new MySubclass("Macarena!", 42);

            Console.ReadKey();
        }
    }
}
