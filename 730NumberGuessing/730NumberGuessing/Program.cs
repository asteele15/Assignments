using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Again, I know it's not functional.. I'm not sure what's wrong w/ the if statements.

//Grade: 8/10 - Syntax errors, does not compile.

namespace _730NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random(); //generate random number
            Console.WriteLine("Guess a number between 1 and 1000");   
            
            int Guess; //gather user guess
            int Answer = number.Next(1001);
            do //loop to continue testing guess against random number
            {
                Guess = Convert.ToInt32(Console.ReadLine()); //gather user guess
                if (Guess == Answer)
                    Console.WriteLine("Congrats! You guessed right!");
                else if (Guess < Answer)
                    Console.WriteLine("Your guess is too low, try again.");
                else if (Guess > Answer)
                    Console.WriteLine("Your guess is too high, try again.");
            } while (Guess != Answer);
            //while loop

        }//end main
    } //end class
}//end namespace
