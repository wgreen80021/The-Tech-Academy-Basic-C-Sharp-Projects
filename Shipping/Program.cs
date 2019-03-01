using System;

namespace Shipping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the package weight");
            string Weight = Console.ReadLine();

            if (Convert.ToInt32(Weight) > 50)
            { Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); }
            else
            {
                Console.WriteLine("Please enter the package width");
                string Width = Console.ReadLine();
                Console.WriteLine("Please enter the package height");
                string height = Console.ReadLine();
                Console.WriteLine("Please enter the package length");
                string length = Console.ReadLine();

                int Sum = Convert.ToInt32(Width) + Convert.ToInt32(height) + Convert.ToInt32(length);

                if (Sum > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    decimal Amount = (Convert.ToDecimal(Sum) * Convert.ToDecimal(Weight)) / 100;
                    Console.WriteLine("The total amount for shipping is : $" + Amount);
                    Console.ReadLine();
                }
            }
        }
    }
}
