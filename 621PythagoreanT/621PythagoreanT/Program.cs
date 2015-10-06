using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Grade: 10/10 Great job
namespace PythagoreanTripleFinder
{

    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 20; a++)//establish and increment a variable
            {
                for (int b = 1; b <= 20; b++) //establish and increment b variable
                {
                    for (int c = 1; c <= 20; c++) //establish and increment c variable
                    {
                        if ((a * a) + (b * b) == c * c) //test variables for pythagorean triple
                        Console.WriteLine("{0}, {1}, {2} ", a, b, c); // action(write each instance of the triples)            
                    }//end if
                }//end c
            }//end b
        }//end a 
    } //end main
}//end class
