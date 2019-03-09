using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    

    public class Employee:Person, IQuittable
    {
        public int id { get; set; }
         
        public void Quit(string msgQuit)
        {
            Console.WriteLine(msgQuit);
            Console.ReadLine();

            //throw new NotImplementedException();
        }
    }
    
}
