using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#1 : Create a one-dimensional Array of strings.Ask the user to input some text.Create a loop that goes through each \nstring in the Array, adding the user’s text to the string.Then create a loop that prints off \neach string in the Array on a separate line.\n\n");

            string[] strArray = new string[5];
            strArray[0] = "David likes to swim ";
            strArray[1] = "John likes to run ";
            strArray[2] = "Harry likes to play ";
            strArray[3] = "Sally likes to bike ";
            strArray[4] = "Tina likes to bake ";

            Console.WriteLine("What would you like to add to the text strings ?");
            string strAdd = Console.ReadLine();


                for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i] + strAdd + "\n");

            }
            Console.ReadLine();

            Console.WriteLine("#2: Create an infinite loop.\n(will print 1 each time you hit enter .....press x to end this....)");

            for (; ; )
            {
                string x = Console.ReadLine();
                if (x != "x")
                {
                    Console.Write(1);
                }

                else
                {
                    break;
                }
            }



            Console.WriteLine("#3 :Fix the infinite loop so it will execute.\nWill run two times..");

            for (int i = 1; i < 3; i++)
            {
                Console.Write(1 + "\n");
            }

            Console.WriteLine("\n\n");
            Console.ReadLine();
            Console.WriteLine("#4.Create a loop where the comparison used to \ndetermine whether to continue iterating the loop is a “<” operator.");

            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i] + strAdd + "\n");
               
            }
            Console.ReadLine();
            Console.WriteLine("\n\n");

            Console.WriteLine("#5.Create a loop where the comparison used to determine whether \nto continue iterating the loop is a “<=” operator.");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(strArray[i] + strAdd + "\n");
            }
            //Console.ReadLine();


            Console.WriteLine("#6.Create a List of strings where each item in the list is unique.Ask the user to select \ntext to search for in the List.Create a loop that \niterates through the list and then displays the index of the \narray that contains matching text on the screen.\n\nSelect a name from the list below to find the index : ");

             
            string[] strArray1 = new string[5];
            strArray1[0] = "David";
            strArray1[1] = "John";
            strArray1[2] = "Harry";
            strArray1[3] = "Sally";
            strArray1[4] = "Tina";
            for (int i = 0; i < strArray1.Length; i++)
            {

                Console.WriteLine(strArray1[i]);

            }

            Console.WriteLine("\n");
            string strSearch = Console.ReadLine();

            for (int i = 0; i < strArray1.Length; i++)
            {
                if (strArray1[i] == strSearch)
                {
                    Console.WriteLine("Index for " + strSearch + " = " + i);
                    
                }

                
                //Console.WriteLine("\n");
            }
            Console.ReadLine();
            Console.WriteLine("#7.Add code to that above loop that tells a \nuser if they put in text that isn’t in the List.\n\n");
            Console.WriteLine("Select a name from the list below to find the index : ");
            string[] strArray4 = new string[5];
            strArray4[0] = "David";
            strArray4[1] = "John";
            strArray4[2] = "Harry";
            strArray4[3] = "Sally";
            strArray4[4] = "Tina";
            for (int i = 0; i < strArray4.Length; i++)
            {

                Console.WriteLine(strArray4[i]);

            }

            Console.WriteLine("\n");
            string strSearch2 = Console.ReadLine();
           
            for (int i = 0; i < strArray4.Length; i++)
            {
                if (strArray4[i] == strSearch2)
                {
                    Console.WriteLine("Index for " + strSearch2 + " = " + i);

                    break;

                }
                
                else if (strArray4.Contains(strSearch2) == false)
                {
                    Console.WriteLine(strSearch2 + " Not Found");
                   // Console.ReadLine();
                    break;
                }
               Console.ReadLine();
            }
            Console.ReadLine();


            Console.WriteLine("#8.Add code to that above loop that stops it from executing once a match has been found.\n");
            Console.WriteLine("Select a name from the list below to find the index : ");
            string[] strArray3 = new string[5];
            strArray3[0] = "David";
            strArray3[1] = "John";
            strArray3[2] = "Harry";
            strArray3[3] = "Sally";
            strArray3[4] = "Tina";
            for (int i = 0; i < strArray3.Length; i++)
            {

                Console.WriteLine(strArray3[i]);

            }

            Console.WriteLine("\n");
            string strSearch3 = Console.ReadLine();
            bool boolFound = false;
            for (int i = 0; i < strArray1.Length; i++)
            {
                if (strArray3[i] == strSearch)
                {
                    Console.WriteLine("Index for " + strSearch3 + " = " + i);
                    Console.ReadLine();
                    boolFound = true;
                    break;
                }

                else if (strArray1.Contains(strSearch3) == false)
                {
                    Console.WriteLine(strSearch3 + " Not Found");
                    Console.ReadLine();
                    break;
                }

            }

            Console.WriteLine("#9.Create a List of strings that has at least two \nidentical strings in the List. Ask the user to select text to \nsearch for in the List.Create a loop that iterates through the \nlist and then displays the indices of the array \nthat contain matching text on the screen. ... contains #10 as well");
            // 10.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            Console.WriteLine("Select a name from the list below to find the index : ");
            string[] strArray5 = new string[5];
            strArray5[0] = "David";
            strArray5[1] = "John";
            strArray5[2] = "David";
            strArray5[3] = "Harry";
            strArray5[4] = "David";
             
            for (int l = 0; l < strArray5.Length; l++)
            {

                Console.WriteLine(strArray5[l]);

            }

           // Console.WriteLine("\n");
            string strSearch5 = Console.ReadLine();

            for (int l = 0; l < strArray5.Length; l++)
            {
                if (strArray5[l] == strSearch5)
                {
                    Console.WriteLine("Index for " + strSearch5 + " = " + l + "\n");
                    for (int x = l + 1; x < strArray5.Length; x++)
                    {
                        if (strArray5[x] == strSearch5)
                        {
                            Console.WriteLine("Index for " + strSearch5 + " = " + x + "\n");
                        }
                    }
                   

                   break;
                }

                else if (strArray5.Contains(strSearch5) == false)
                {
                    Console.WriteLine(strSearch5 + " Not Found");
                    Console.ReadLine();
                    break;
                }

            }

            Console.ReadLine();

            Console.WriteLine("#11.Create a List of strings that has at least two \nidentical strings in the List. Create a foreach\nloop that evaluates each item in the list, and displays a message \nshowing the string and whether or not it has already appeared in the list.");

            string[] names = { "David", "John", "Harry", "David", "Sally", "David", "Tina", "Kate", "David" };

            int j = 0;
            foreach (string value in names)
            {
                {

                    {
                        Console.WriteLine("Index for " + names[j] + " = " + j + "\n");
                        for (int x = 0; x < names.Length; x++)
                        {
                            if (names[x] == names[j] && x < j)
                            {
                                Console.WriteLine(names[x] + " has previously appeared in list at index " + x + "\n");
                            }
                        }
                        j++;
                        //Console.ReadLine();
                    }
                }

            }
            Console.ReadLine();
        }
        
        
    }
   
}
           
