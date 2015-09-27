using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Again, I know it's not functional.. I'm not sure what's wrong w/ the if statements.

namespace _730NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random( 1000 ); //generate random number
            Console.WriteLine("Guess a number between 1 and 1000");   
            
            int Guess = Convert.ToInt32(Console.ReadLine()); //gather user guess

            while ( Guess != number ) //loop to continue testing guess against random number
                Guess = Convert.ToInt32(Console.ReadLine()); //gather user guess
            if ( Guess = number )
                Console.WriteLine("Congrats! You guessed right!");
            else (Guess < number );
                Console.WriteLine( "Your guess is too low, try again." );
            else (Guess > number );
                Console.WriteLine( "Your guess is too high, try again." );
            

        }//end main
    } //end class
}//end namespace
