using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _730NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random(); //generate random number
            Console.WriteLine("Guess a number between 1 and 1000");   
            
            int Guess;
            int Answer;
            Answer = number.Next(1, 1000);

            do 
            {
                Guess = Convert.ToInt32(Console.ReadLine());

            if ( Guess == Answer )
                Console.WriteLine("Congrats! You guessed right!");
            else if (Guess < Answer )
                Console.WriteLine( "Your guess is too low, try again." );
            else if (Guess > Answer )
                Console.WriteLine( "Your guess is too high, try again." );
            }while (Guess != Answer);
            
            
        }//end main
        public static int Random()
        {
            Random number = new Random();
            int Answer;
            Answer = number.Next(1, 1000);
            return Answer;
        }
    } //end class
}//end namespace
