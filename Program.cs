using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time Right Now is : {0}",  DateTime.Now);
            Console.WriteLine("Please enter number of hours to add : ");
            double dateOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The adjusted time is : {0}",  DateTime.Now.AddHours(dateOne));
            Console.ReadLine();
            
             

        }
    }
}
