using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Except1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ValidAge = false;
            int Age = 0;
            DateTime dateNow = DateTime.Today;
            
            try
            {
                Console.WriteLine("Please enter your age:  ");
                 
                

                
                ValidAge = int.TryParse(Console.ReadLine(), out Age);
                if (ValidAge && (Age > 0))
                {
                    DateTime dateBorn = dateNow.Date.AddYears(Age * -1);
                    Console.WriteLine("Your Birthdate is {0}", dateBorn);
                    Console.ReadLine();
                    return;
                }
                {
                    if (Age <= 0 && ValidAge)
                    {

                        throw new FormatException();
                    }
                }  
                { 
                    
                        throw new Exception();
                }
          
                
                 
            }
            catch (FormatException)
            {
                Console.WriteLine("Entry cannot be 0 or less ");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry made .....");
                Console.ReadLine();
                
                
            }
        }

    }



}
    

