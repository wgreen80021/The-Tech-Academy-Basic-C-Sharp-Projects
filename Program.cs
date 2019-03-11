using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumCatch
{
    class Program
    {
        public enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        static void Main(string[] args)
        {



            bool Except = true;
            while (Except)

                try
                {
                    Console.WriteLine("Enter the day of the week : ");
                    string strDay = Console.ReadLine();
                    Days days = (Days)Enum.Parse(typeof(Days), strDay);
                    Console.WriteLine(strDay + " is a match !!    ");
                    Except = false;
                    //return;
                }
                catch (SystemException ex)
                {
                    Console.WriteLine(ex.Message + "..... Please enter a valid day of the week...  ");
                    Except = true;
                    //return;

                }
            Console.ReadLine();
        }



    }
}

