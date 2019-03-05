using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass3 a = new MathClass3();
            int z = a.DoStuff(x: 5);
            Console.WriteLine("Integer :" + z);
            decimal d = a.DoStuff(x: 5.5m);
            Console.WriteLine("Decimal :" + d);
            string s = a.DoStuff(x: "12");
            Console.WriteLine("String  :" + s);
            Console.ReadLine();
        }
    }
}
