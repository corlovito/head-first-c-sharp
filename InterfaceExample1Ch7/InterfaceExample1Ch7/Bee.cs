using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1Ch7
{
    class Bee : IStingPatrol
    {
        private int _alertLevel = 0;
      
        public int AlertLevel { get { return _alertLevel; } }
        public int StingerLength { get; set; }
        public bool LookForEnemies() { return true; } 
        public int SharpenStinger(int length) { return 1; }

    }
}
