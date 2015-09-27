using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage7.8
{

    public class ParkingGarage
    {     
        //I honestly am at a loss at what I am doing wrong, 
        //I think I get the general ideas of these things, and have reviewed the sytax in the book,
        //but clearly I'm missing something

      public static void Main(string[] args)
        {
            //get number of cars to report fees for
            Console.WriteLine("How many cars parked in the garage yesterday?");
            int counter = Convert.ToInt16( Console.ReadLine() );  //assign counter to run for total number of cars

            //loop to gather how many hours each car parked for and
            //calucate fees 
            for ( counter )
            {
            int total = CalculateCharges( int fee ) ;
            Console.WriteLine( "{0}", total; );
            }//end for

       public static int CalculateCharges( int fee );
             int hours = Convert.ToInt32(Console.ReadLine() );
             int fee = 2;
             if ( int hours; hours <= 3; )
             {   fee = 2;
            else 
            {    if ( int hours = 3; hours >= 23)
                    fee = 10;  //max fee
                 else
                    fee = .5(hours - 3);  //calculation for hours above min charge of 3
            }//end else if
    }       // end calculate charges


    public static int hours( int hours)
{   Console.WriteLine("How many hours did the car park for?"); 
    int hours = Convert.ToInt32(Console.ReadLine() );
}//end hours
      }//end main

     

              

   }//end class

