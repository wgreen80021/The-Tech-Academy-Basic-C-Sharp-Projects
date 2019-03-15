using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DrillIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number");
            File.WriteAllText(@"C:\Users\Wendy\Documents\School\c#\DrillIO1.txt", Console.ReadLine());
            Console.WriteLine(File.ReadAllText(@"C:\Users\Wendy\Documents\School\c#\DrillIO1.txt"));
            Console.ReadLine();
        }
    }
}
