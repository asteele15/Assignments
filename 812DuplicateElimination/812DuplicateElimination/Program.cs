using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Grade:8/10
//Missing Requirements:
//Write an app that inputs 5 numbers - your app inputs numbers until there are 5 unqiue numbers so there is no limit on the number of inputs
//Use the smallest array possible - an array of 4 values is all that is required because the 5th does not need to be stored when you have a limit as indicated in the requirement above.
//You app only considers an input a duplicate if it is the same as the previous input not any of the inputs.  This could be resolved by looping through the array to determine if any of the values are a duplicate.
namespace _812DuplicateElimination
{
    class Program
    {


        static void Main(string[] args)
        {   int[] array = new int[5]; //one dimensional array

        for (int counter = 0; counter < array.Length; counter++) //loop through array
        {
            try
            {
                Console.WriteLine("Enter a number between 10 and 100"); //prompt user for input
                array[counter] = Convert.ToInt32(Console.ReadLine()); //assign input to array location
                if (array[counter] == array[counter - 1])//if duplicate assign nothing and redo counter
                {
                    array[counter] = 0;
                    counter = counter - 1;
                    continue;
                }
                else if (array[counter] < 10) //number can't be less than 10
                {
                    Console.WriteLine("Number can not be less than 10");
                    array[counter] = 0;
                    counter = counter - 1;
                    continue;
                }
                else if (array[counter] > 100)//number can not be greater than 100- retry
                {
                    Console.WriteLine("Number can not be greater than 100");
                    array[counter] = 0;
                    counter = counter - 1;
                    continue;
                }
                else //default if none of the previous provisions apply
                {
                    Console.WriteLine("{0}{1,8}", "index", "value");
                    Console.WriteLine("{0,5}{1,8}", counter, array[counter]);

                }//end else
            }//end try
            catch // for first provision to catch duplicates
            {
                Console.WriteLine("{0}{1,8}", "index", "value");
                Console.WriteLine("{0,5}{1,8}", counter, array[counter]);
                continue;
            }
        }//end for
        Console.WriteLine("{0}{1,8}", "index", "value");//display full array
        for ( int counter = 0; counter < array.Length; ++counter)
            Console.WriteLine("{0,5}{1,8}", counter, array[counter]);
        Console.ReadLine();

        }//end main
        
   }//end class
}//end namespace
