using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //IQuittable quit = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.id = 1 ;
           employee.SayName();

            Employee employee2 = new Employee();
            employee2.FirstName = "Wendy";
            employee2.LastName = "Smith";
            employee2.id = 2;
            employee2.SayName();
            Console.WriteLine("Enter id for employee 1: ");
            int EId1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter id for employee 2: ");
            int EId2 = Convert.ToInt32(Console.ReadLine());

            employee.id = EId1;
            employee2.id = EId2;


            Console.WriteLine("Do these Id's match ? " + (employee == employee2));
            Console.ReadLine();
            




            //quit.Quit("I Quit");

        }

       
    }
}
