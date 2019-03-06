using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill5
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassDrill5 a = new ClassDrill5();
            Console.WriteLine("Enter a number that will be divided by 2 :");
            string stringX = Console.ReadLine();

            bool b = stringX.Contains(".");

            if (b == true)
            { 
               
                    decimal x = Convert.ToDecimal(stringX);
                    a.DivideBy2(x, out decimal y);
                Console.WriteLine("The answer is : " + y);
                Console.ReadLine();
            }
            else
            {
                int x = Convert.ToInt32(stringX);
                a.DivideBy2(x, out int y);
                Console.WriteLine("The answer is : " + y);
                Console.ReadLine();

            }
            

            


            
            
        }
    }
}
