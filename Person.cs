﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    public abstract class Person
    {
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            //  Console.ReadLine();


        }


        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

}
