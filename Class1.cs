using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillsVar1
{
    class Class1
    {

        public Class1(string Fname, string Lname, string Address)
        {    
            e_Fname = Fname;
            e_Lname = Lname;
            e_Address = Address;
        }

         
       
        public Class1(string Fname, string Lname) : this(Fname, Lname, "123 Main Street")
        {
        }

        public string e_Fname, e_Lname, e_Address;
        
        
    }
}
