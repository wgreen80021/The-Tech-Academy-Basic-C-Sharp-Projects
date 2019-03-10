using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic { 
public class Employee<T>:Person
       
{
    public int id { get; set; }
    public List<T> Things = new List<T>();


    //public static  Boolean  operator==(Employee emp1, Employee emp2)
    //{
    //   bool z =    emp1.id == emp2.id;
    //   return z;

            //}
            //public static Boolean operator !=(Employee emp1, Employee emp2)
            //{
            //    bool z = emp1.id == emp2.id;
            //    return z;

            //}
        public void Quit(string msgQuit)
    {
        Console.WriteLine(msgQuit);
        Console.ReadLine();



        //throw new NotImplementedException();
    }

    //public static implicit operator Employee<T>(List<int> v)
    //{
    //    throw new NotImplementedException();
    //}
    //public static implicit operator Employee<T>(List<string> v)
    //{
    //    throw new NotImplementedException();
    //}
}
}


