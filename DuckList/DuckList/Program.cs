using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13 },
            };

            //ducks.Sort();

            DuckComparerBySize compareBySize = new DuckComparerBySize();
            DuckComparerByKind compareByKind = new DuckComparerByKind();

            ducks.Sort(compareBySize);
            Console.WriteLine("Sort by size:");
            PrintDucks(ducks);

            ducks.Sort(compareByKind);
            Console.WriteLine("Sort by kind:");
            PrintDucks(ducks);

            Console.ReadKey();
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
                Console.WriteLine(duck.Size.ToString() + "-inch " + duck.Kind.ToString());
            Console.WriteLine("End of ducks.\n");
        }

    }
}
