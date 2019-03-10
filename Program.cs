using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.FirstName = "Wendy";
            employee.LastName = "Smith";
            employee.id = 1;
            employee.Things.Add("One");
            employee.Things.Add("Two");
            employee.Things.Add("Three");


                  

        Employee<int> employee2 = new Employee<int>();
            employee2.FirstName = "Wendy";
            employee2.LastName = "Smith";
            employee2.id = 1;
            employee2.Things.Add(1);
            employee2.Things.Add(2);
            employee2.Things.Add(3);

          
          
        int x = 0;

            while (x < employee.Things.Count())
            {
                Console.WriteLine(employee.Things[x]);
                x++;


            }

     
            int z = 0;


            while (z < employee2.Things.Count())
            {
                Console.WriteLine(employee2.Things[z]);
                z++;

               
            }
            Console.ReadLine();

        }





    }
        }
    




