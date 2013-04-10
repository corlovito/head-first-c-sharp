using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZWTesting
{
    class LZW
    {
        
      

        public void tester()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("one", 2);

            List<int> k;
            k = new List<int>();

            k.Add(4);
            k.Add(dict["one"]);

            System.Windows.Forms.MessageBox.Show("Elements: " + k.Count());
            System.Windows.Forms.MessageBox.Show("Contents: " + k[0] + " " + k[1]);

        }
        


    }
}
