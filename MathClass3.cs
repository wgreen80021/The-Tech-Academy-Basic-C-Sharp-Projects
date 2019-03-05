using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill3
{
    public class MathClass3
    {
        public int DoStuff(int x)
        {

            return x + 1;

        }
        public decimal DoStuff(decimal x)
        {

            return x *  1.5m;

        }

        public string DoStuff(string x)
        {

            return x + " is now a string";

        }
    }
}
