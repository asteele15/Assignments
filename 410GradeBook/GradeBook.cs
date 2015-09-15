using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Gradebook
{
   // auto-implemented property CourseName implicitly created an
    //instance variable for this GradeBook's course name
    public string CourseName { get; set; }
    public string InstructorName { get; set; }

    //constructor initializes auto-implemented property
    // CourseName with string supplied as argument
    public Gradebook( string name, string name2 )
    {
        CourseName = name; //set CourseName to name
        InstructorName = name2; //set InstructorName to name2
    } // end constructor

    

    //display welcome message to the GradeBook user
    public void DisplayMessage()
    {
        //use auto-implemented property CourseName to get the 
        //name of the course that this GradeBook represents
        Console.WriteLine( "Welcome to the grade book for {0}!\nClass is instructed by: {1}",
            CourseName, InstructorName );
    } // end method DisplayMessage
} // end class GradeBook
