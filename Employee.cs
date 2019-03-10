using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    

    public   class Employee:Person, IQuittable
    {
        public int id { get; set; }
        public static  Boolean  operator==(Employee emp1, Employee emp2)
        {
           bool z =    emp1.id == emp2.id;
           return z;

        }
        public static Boolean operator !=(Employee emp1, Employee emp2)
        {
            bool z = emp1.id == emp2.id;
            return z;

        }
        public void Quit(string msgQuit)
        {
            Console.WriteLine(msgQuit);
            Console.ReadLine();



            //throw new NotImplementedException();
        }

        

    }
    }
    

