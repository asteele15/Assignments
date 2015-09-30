using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cars parked in the Garage yesterday?");
           int count = Convert.ToInt32( Console.ReadLine() ); 
           int hours = ParkingGarage.hours();
           int fee = ParkingGarage.CalculateCharges();

           Console.WriteLine("The total fee's for yesterday's cars are: \n {0}", fee); 
        }

        public static int hours( int total)
        {   int hours = 3;
            Console.WriteLine("How many hours did the car park for?");
            hours = Convert.ToInt32( Console.ReadLine() );
        }//end hours

        public static int CalculateCharges(int fee)
        {
            int total = 2;
            if (ParkingGarage.hours > 3)
                total = (1/2) * (ParkingGarage.hours - 3);


        }
    }
}