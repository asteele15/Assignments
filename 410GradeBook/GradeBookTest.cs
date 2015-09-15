using System;

public class GradeBookTest
{
    // main method begins prgoram execution
    //static can be called without creating an object
    public static void Main(string[] args)
    {
        // create a gradebook object  
        Gradebook GradeBook1 = new Gradebook( //invokes constructor
            name: "COP 2360: Programming in C#",
            name2: "Prof. April Graves" ); //constructor
        
    
        // display initial value of courseName for each Gradebook
                GradeBook1.DisplayMessage();
        Console.ReadLine(); // output a blank line
        

        }// end Main
} // end class GradeBookTest

