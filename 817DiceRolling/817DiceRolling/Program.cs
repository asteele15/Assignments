using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _817DiceRolling
{
    class Program 
    {
        Random randomNumber = new Random(); //random number

        static void Main(string[] args)
        {   int[] tally = new int[36000];  //array for rolls

            for (int count = 0; count <= tally.Length; count++ )
            { int sum = Roll();
                tally[count] = sum;
            }
                                      
            int[] results = new int[10];

            foreach( int sum in tally )
            {
                if ( sum == 2 );
                    Console.WriteLine("*");
                else ( sum == 3 );
                    Console.WriteLine("*");
                else ( sum == 4 ):
                Console.WriteLine("*");
                else ( sum == 5 ); 
                Console.WriteLine("*");
                else ( sum == 6 ); 
                Console.WriteLine("*");
                else ( sum == 7 ); 
                Console.WriteLine("*");
                else ( sum == 8 ); 
                Console.WriteLine("*");
                else ( sume == 9 );
                Console.WriteLine("*");
                else ( sum == 10 );
                   Console.WriteLine("*");
                else (sum == 11 ); 
                Console.WriteLine("*");
                else (sum == 12 ); 
                Console.WriteLine("*");
            }//for each
           
        }//main
        

        public static int Roll()
        {
            int die1 = randomNumber.Next(1, 7);
            int die2 = randomNumber.Next(1, 7);
            int total = die1 + die2;
            return (total);

        }//Roll

        public void Results()
        {
            Console.WriteLine( "Overall Dice Rolls:" );

            int[] frequency = new int[6];
 
            foreach (int sum in tally )
            {
                ++frequency[ sum ];
            }

            for ( int count = 0; count < frequency.Length; ++count )
            {
                if (count == 0 )
                    Console.Write( " 100: "); 
                else 
                    Console.Write( "{0:D2}-{1:D2}: ",
                        count * 10, count * 10+9 );

                for (int stars = 0; stars < frequency[ count ]; ++stars )
                    Console.WriteLine( "*" );
                        

               
    }//class
}//namespace
