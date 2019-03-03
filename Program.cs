using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 4, 34, 3, 6, 8, 19 };

                foreach( int number in numbers )
                {
                    Console.WriteLine(number);
                }
                //Console.ReadLine();

                Console.WriteLine("pick a number to divide each of the above numbers by: ");
                int intNumberOne = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    int Answer = number / intNumberOne;
                    Console.WriteLine(number + " divided by " + intNumberOne + " = " + Answer);
                    
                }
               

               

            }
            catch(FormatException ex)
            {

                Console.WriteLine(ex.Message + "..... Please enter a whole number ");
                return;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message + "..... Please do not divide by zero ");
                return;
            }

            finally
            {
                // Console.ReadLine();
                Console.WriteLine("Exiting the TRY / CATCH Section of our Code ....");
                Console.ReadLine();

            }
            
        }
    }
}
