using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings1
{
    class Program
    {
        static void Main(string[] args)
        { 
            string strSent1 = "This is part one ";
            string strSent2 = " This is part2 ";
            string strSent3 = " This is Part 3 \n";
            string sbL1 = "This is line one of the paragraph I am going to string. \n";
            string sbL2 = "This is line two of the paragraph I am going to string.\n";
            string sbL3 = "This is line three of the paragraph I am going to string.\n";
            string sbL4 = "This is line four of the paragraph I am going to string. \n";
            string sbL5 = "This is line five of the paragraph I am going to string. \n";
            string sbL6 = "This is line six of the paragraph I am going to string. \n";



            string concSent = strSent1.ToUpper() + strSent2 + strSent3;
           

            StringBuilder sb = new StringBuilder(concSent);

           
            sb.Append(sbL1);
            sb.Append(sbL2);
            sb.Append(sbL3);
            sb.Append(sbL4);
            sb.Append(sbL5);
            sb.Append(sbL6);

            
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
