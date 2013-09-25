using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckList
{
    class Duck
    {
        public int Size;
        public KindOfDuck Kind;
    }

    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy,
    }
}
