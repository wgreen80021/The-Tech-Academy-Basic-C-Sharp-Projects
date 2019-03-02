using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 0;
            int i = 0;
            while (x < 5)
            {
                i = 0;
                x = x + 1;
                do
                {
                    Console.WriteLine("X = " + x + " I = " + i);
                    i = i + 1;


                } while (i < 5);
                


            }
            Console.ReadLine();
        }
    }
}