using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lamda1
{
    class Program
    {
        static void Main(string[] args)
        {

          

            List<Employee> employees = new List<Employee>();
            List<TempEmployee> TmpEmp = new List<TempEmployee>();
             


             

            employees.Add(new Employee { FName = "Joe", LName = "Smith" , Id = 1 });
            employees.Add(new Employee { FName = "Jamie", LName = "Doe", Id = 2 });
            employees.Add(new Employee { FName = "Sally", LName = "North", Id = 3 });
            employees.Add(new Employee { FName = "Joe", LName = "West", Id = 4 });
            employees.Add(new Employee { FName = "Ken", LName = "Lamm", Id = 5 });
            employees.Add(new Employee { FName = "Bill", LName = "South", Id = 6 });
            employees.Add(new Employee { FName = "Joe", LName = "Toast", Id = 7 });
            employees.Add(new Employee { FName = "Bob", LName = "Smith", Id = 8 });
            employees.Add(new Employee { FName = "Sue", LName = "Brown", Id = 9 });
            employees.Add(new Employee { FName = "Clive", LName = "Black", Id = 10 });




            int i = 0;
            foreach (Employee employee in employees)


            {
                if (employee.FName == "Joe")
                {
                    TmpEmp.Add(new TempEmployee { FName = employee.FName, LName = employee.LName, Id = employee.Id });
                    Console.WriteLine(TmpEmp[i].FName + " " + TmpEmp[i].LName);
                    i++;
                }

            }
            Console.WriteLine("\n");
            var NewList = employees.Where(x => x.FName == "Joe");
            foreach (var item in NewList)
            {
                Console.WriteLine("{0} {1}", item.FName, item.LName);
            }
            Console.WriteLine("\n");
            var NewList2 = employees.Where(x => x.Id > 5);
            foreach (var item in NewList2)
            {
                Console.WriteLine("{0} {1} {2}", item.FName, item.LName, item.Id);
            }

 
            Console.ReadLine();
             
        }
                    
            
     
                }
                         
                    }
    

