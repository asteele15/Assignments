// Exercise 12.11 Solution: PayrollSystemTest.cs
// Employee hierarchy test program.
using System;

public class PayrollSystemTest
{
    public static void Main(string[] args)
    {
        // create five-element Employee array
        Employee[] employees = new Employee[5];

        // initialize array with Employees
        employees[0] = new SalariedEmployee("John", "Smith",
           "111-11-1111", 800M);
        employees[1] = new HourlyEmployee("Karen", "Price",
           "222-22-2222", 16.75M, 40M);
        employees[2] = new CommissionEmployee("Sue", "Jones",
           "333-33-3333", 10000M, .06M);
        employees[3] = new BasePlusCommissionEmployee("Bob", "Lewis",
           "444-44-4444", 5000M, .04M, 300M);
        employees[4] = new PieceWorker("Jared", "Jay",
            "555-55-5555", 500, 20); 

        Console.WriteLine("Employees processed polymorphically:\n");

        // generically process each element in array employees
        foreach (var currentEmployee in employees)
        {
            Console.WriteLine(currentEmployee); // invokes ToString
            Console.WriteLine("earned {0:C}\n",
               currentEmployee.Earnings());
        } // end foreach
    } // end Main
} // end class PayrollSystemTest