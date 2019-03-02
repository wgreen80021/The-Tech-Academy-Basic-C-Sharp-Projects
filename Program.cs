using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string[] strArray = new string[] { "Zero", "One", "Two", "Three", "Four" };

        Console.WriteLine("Please select an index from 0 to 4 for the string array : ");
        string selInd = Console.ReadLine();
        
        

        if (Convert.ToInt32(selInd) < 5)
        {
            sb.Append("String Array value is : " + strArray[Convert.ToInt32(selInd)] + "\n");
         
        }
        else
        {
              sb.Append("Index " + (selInd) + " for the string array is outside the allowable range \n");
            
        }
       


        int[] intArray = new int[] { 0, 1, 2, 3, 4 };
        Console.WriteLine("Please select an index from 0 to 4 for the numeric array : ");
        string selInd2 = Console.ReadLine();

        if (Convert.ToInt32(selInd2) < 5)
        {

            sb.Append("Numeric Array value is : " + intArray[Convert.ToInt32(selInd2)]);
          
        }
        else
        {
            sb.Append("Index " + (selInd2) + " for the numeric array is outside the allowable range \n");

        }
        Console.WriteLine(sb);
        //Console.ReadLine();


        List<string> strList2 = new List<string>();
        strList2.Add("PASS");
        strList2.Add("FAIL");



        List<string> strList = new List<string>();

        strList.Add("We saved so much time deciding to Pass this project ! \n");
        strList.Add("Are you sure about the  Fail ?  ...  maybe you should rethink it ?????\n");
        strList.Add("Seriously , incorporated items from last lesson ...  gonna have to ask one more time .... \n");
        strList.Add("ok ..  this will go on forever ....  Last Time   \n");
        strList.Add("Not taking no for an ansewr .... Let's end this agree to " + strList2[0] + "  :)  Have a great Day \n");

       
        
        int i = 0;



        do
        {
            Console.WriteLine("Did this project pass ?  \nPlease select : \n0 - for Pass\n1 - for Fail \n");
            string ansPassFail = Console.ReadLine();
            


            switch (ansPassFail)
            
            {
                case "0":
                    i = 0;
                    Console.WriteLine(strList2[Convert.ToInt32(ansPassFail)] + "\n" +  strList[i]);
                    i = 5;
                    //Console.ReadLine();
                    break;
                case "1":
                    i++;
                    Console.WriteLine(strList2[Convert.ToInt32(ansPassFail)] + "\n" + strList[i]);
                    
                   // Console.ReadLine();
                    break;
            } //Console.ReadLine();
            
        } while (i < 4);

        Console.ReadLine();
        
    }
}
