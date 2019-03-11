using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structAmount
{
    class Program
    {
        public static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 4.00m;

            Console.WriteLine(number.Amount );
            Console.ReadLine();
     }
         
    }
    
}
