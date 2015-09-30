using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _522tabularOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N  10*N   100*N   1000*N");
            //declare variable
            int N = 0;
            int C1 = 10; 
            int C2 = 100;
            int C3 = 1000; 

            //increase and display variable from 10-50
            while (N < 5 )
            {
                N++;
                Console.Write(N + "   " ); 
                Console.Write(N * C1 + "    " );
                Console.Write(N * C2 + "     " );
                Console.Write(N * C3 );
                Console.WriteLine();
                                }

        }
    }
}
