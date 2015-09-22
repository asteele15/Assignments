using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PythagoreanTripleFinder
{

    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 500; a++)//establish and increment a variable
            {
                for (int b = 1; b <= 500; b++) //establish and increment b variable
                {
                    for (int c = 1; c <= 500; c++) //establish and increment c variable
                    {
                        if ((a * a) + (b * b) == c * c) //test variables for pythagorean triple
                        Console.WriteLine("{0}, {1}, {2} ", a, b, c); // action(write each instance of the triples)            
                    }//end if
                }//end c
            }//end b
        }//end a 
    } //end main
}//end class
