// 3.31 - BMI Calculator
// Alicia Steele 9/7

using System;

//Grade: 10/10 Great job!
public class Calculator
{
    //Primary Method for I/O of application
    public static void Main(string[] args)
    {
        //declaring variables
        int weight ; 
        int height ; 
        int BMI ; 

        //Gatering data for variables
        Console.WriteLine( "Please enter your weight in pounds."); 
        weight = Convert.ToInt32( Console.ReadLine() ); 

        Console.WriteLine ("Please enter your height in inches."); 
        height = Convert.ToInt32( Console.ReadLine() ); 

        //calculate BMI from formula
        BMI = ( weight * 703 ) / (height * height ); 

        //Display BMI along with other essential information for interpretation
        Console.WriteLine("Your BMI is {0}", BMI ); 
        Console.WriteLine("\n BMI VALUES" );
        Console.WriteLine("Underweight: less than 18.5");
        Console.WriteLine("Normal: between 18.5 and 24.9");
        Console.WriteLine("Overweight: between 25 and 29.9");
        Console.WriteLine("Obese: 30 or greater");

        //keep application open to read results
        Console.ReadLine();
    }//end Main

}//End Calculator
