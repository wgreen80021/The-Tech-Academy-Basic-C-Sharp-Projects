using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number that will be added to a second number :");
            string strInNum1 = Console.ReadLine();

            Console.WriteLine("You may enter a second number or leave blank to use the default :");
            
            string strInNum2 = Console.ReadLine();

            ClassDrill4 a = new ClassDrill4();

            switch  (strInNum2)
            {
                case "":
                    int x = a.AddValues(Convert.ToInt32(strInNum1));
                    Console.WriteLine("Your answer is : " + x + " using the default value of 1");
                    Console.ReadLine();
                    break;

                default:
                    int z = a.AddValues(Convert.ToInt32(strInNum1), Convert.ToInt32(strInNum2));
                    Console.WriteLine("Your answer is : " + z );
                    Console.ReadLine();

                    break;

                    
            }

        }
    }
}
