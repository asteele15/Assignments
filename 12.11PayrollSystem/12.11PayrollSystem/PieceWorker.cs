using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Grade: 9.5
//Observations: see comments below
class PieceWorker : Employee
    {
        private decimal wage;
        private decimal piece;

        public PieceWorker(string first, string last, string ssn,
           decimal earnings, decimal rate)
            : base(first, last, ssn)
        {
            //you are setting the parameters  = to the local instance variables ...this will not do anything. 
            //the parameters lose scope after the constructo and the wage and piece instance vars will never have any value while the object is being instanciated
            rate = wage;
            earnings = wage * piece;
        }

        public decimal Wage
        {
            get
            {
                return wage;
            } // end get
            set
            {
                if (value >= 0) // validation
                    wage = value;
                else
                    throw new ArgumentOutOfRangeException("Wage",
                       value, "Wage must be >= 0");
            } // end set
        } // end property Wage

        public decimal Piece
        {
            get
            {
                return Piece;
            } // end get
            set
            {
                if (value >= 0 ) // validation
                    piece = value;
                else
                    throw new ArgumentOutOfRangeException("Piece",
                       value, "Pieces must be >= 0");
            } // end set
        } // end property Hours

        public override decimal Earnings()
        {
            decimal earnings = wage * piece;
            return earnings;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}\nsocial security number: {2}, {3}",
               FirstName, LastName, SocialSecurityNumber, wage);
        } // end method ToString


    }
