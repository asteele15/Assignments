using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage78
{
    public class ParkingGarage
    {     
      public static void Main(string[] args)
        { //
          Console.WriteLine("How many cars parked in the garage yesterday?"); //determine max number of loops
              int cars = Convert.ToInt32( Console.ReadLine() ); //ask how many cars to run totals for
              double total = 0;

              for (int count = 1; count <= cars; count++) //create loop and run time
              {
                  Console.WriteLine("How many hours did car {0} park?", count); //gather information for first car
                  double hours = Convert.ToDouble( Console.ReadLine() );
                  hours = Math.Ceiling(hours);     //round hours up

                  double charge = CalculateCharges(hours); //calculate charges using method
                  total += charge; //add to running total
                  Console.WriteLine("The charge for car {0} is {1}. \n The total charges for yesterday's cars is: {2}",
                      count, charge, total); //display information
                  Console.WriteLine("Press Enter to continue"); //guid user
                  Console.ReadLine(); //pause for user
              }//end for loop
          }//main  

      public static double CalculateCharges(double hours)
    {   double charges = 0;  //declare variable
          if ( hours <= 3 ) //less than hours = minimum charge
              charges = 2;
          if (hours > 3)    
              charges = 2 + (hours - 3)/2;  //calculate charges for hours above 3
          if (charges > 10)
              charges = 10;                 //establish max charge
           return charges;
    }       // end calculate charges

     }//end class

}//end namespace