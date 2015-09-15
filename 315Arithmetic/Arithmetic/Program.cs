// Assignment 3.15
// Displaying Arithmetic

using System;

public class Arithmetic
{
    //Main method - execution of application
    public static void Main(string[] args) 
    {
    //Declare variables
    int number1; 
    int number2; 
    int sum; 
    int difference; 
    int product; 
    int quotient; 

    Console.WriteLine( "Please enter a number: "); //ask user a question
    number1 = Convert.ToInt32( Console.ReadLine() ); 

    Console.Write( "Please enter another number: "); //retreive number 2
    number2 = Convert.ToInt32( Console.ReadLine() ); 

        //perform calculations
        sum = number1 + number2;
        difference = number1 - number2 ;
        product = number1 * number2;
        quotient = number1 / number2 ;

            //display results of calculations
Console.WriteLine( "Sum is {0}", sum); 
Console.WriteLine( "Difference is {0}", difference); 
Console.WriteLine( "Product is {0}", product); 
Console.WriteLine( "Quotient is {0}", quotient);
Console.Read();
    } //end main
} //end class



