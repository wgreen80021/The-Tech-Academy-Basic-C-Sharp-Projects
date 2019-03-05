using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number that will have 5 added to it , 5 subtracted from it, and multiplied by 5 :");
            string strInNum = Console.ReadLine();
            int b = Convert.ToInt32(strInNum);
            MathDrill a = new MathDrill();
                int x = a.AddValues (5, b);
                int y = a.SubrtractValues(5, b);
                int z = a.MultiplyValues (5, b);
            
            Console.WriteLine( "5 Plus " + strInNum + " = "  + x);
                Console.WriteLine("5 Minus " + strInNum + " = "  + y);
            Console.WriteLine( "5 Multiplied by " + strInNum +  "  = " + z);
            
            Console.ReadLine();

        }
    }
}
