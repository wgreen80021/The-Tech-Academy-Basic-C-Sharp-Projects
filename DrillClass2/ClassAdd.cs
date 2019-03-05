using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillClass2
{
    class ClassAdd
    {
        public void AddValues(int x, int y)
        {
            for (int i = 0; i < y; i++)

                x = x + y;
             

            Console.WriteLine(y + " is the second number");
            Console.ReadLine();

        }

            
    }
}
