using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillsVar1
{
    class Program
    {


        static void Main(string[] args)
        {
            var x = "Wendy";
            const string cAddr = "777 Lucky Lane";

            Class1 myClass = new Class1(x, "Smith", cAddr);

            Console.WriteLine("Example assigning all three values : {0} {1} {2}" , myClass.e_Fname, myClass.e_Lname, myClass.e_Address) ;
            Console.ReadLine();

            Class1 myClass2 = new Class1(x, "Smith"); 

            Console.WriteLine("Example assigning only two values : {0} {1} {2}", myClass2.e_Fname, myClass2.e_Lname, myClass2.e_Address);
            Console.ReadLine();
             
        }
        
    }
}
