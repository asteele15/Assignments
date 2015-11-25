using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Grade 7.5
//You have an issue with the for loops that are looping for rolls.length.  Note that you are looping 36000 times and for each one of those loops you are looping another 36000 times.  This is a lot of unnecessary looping.  you don't need both for loops.
//You should remove the inner for loop that is looping for rolls.length 
//you are also outputting the results within the outer for loop which means that the output will be displayed 36000 times.
//Once those issues are fixed, there are still errors in the output due to the way you are outputting the results
namespace _817DiceRolling
{
    class Program 
    {
        static void Main(string[] args)
        {   
            //rolling two dice and storing results in rolls array
            int[] rolls = new int[36000];
            for (int count = 0; count < rolls.Length; count++) //roll die length times 
            {
                rolls[count] = Roll();

                int[] results = new int[11];

                for (int counter = 0; counter < rolls.Length; counter++) //tally results per total
                {
                    if (rolls[counter] == 2)
                        results[0] += 1;
                    else if (rolls[counter] == 3)
                        results[1] += 1;
                    else if (rolls[counter] == 4)
                        results[2] += 1;
                    else if (rolls[counter] == 5)
                        results[3] += 1;
                    else if (rolls[counter] == 6)
                        results[4] += 1;
                    else if (rolls[counter] == 7)
                        results[5] += 1;
                    else if (rolls[counter] == 8)
                        results[6] += 1;
                    else if (rolls[counter] == 9)
                        results[7] += 1;
                    else if (rolls[counter] == 10)
                        results[8] += 1;
                    else if (rolls[counter] == 11)
                        results[9] += 1;
                    else if (rolls[counter] == 12)
                        results[10] += 1;
                }//end for


                Console.WriteLine("{0}{1}", "index", "value");
                for (int index = 0; index < results.Length; index++) //display column of results headers
                {

                    Console.WriteLine("{0}\t{1}", index + 2, results[index]); //display results created in results array
                }//end for
            }

            Console.ReadLine();
        }//main


        public static int Roll() //generate new sum for each roll
        {   Random number = new Random();
            int die1 = number.Next(1,7);
            int die2 = number.Next(1, 7);
            int total = die1 + die2;
            return (total);

        }//Roll               
    }//class
}//namespace
