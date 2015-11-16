using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PieceWorker : Employee
    {
        private decimal wage;
        private decimal piece;

        public PieceWorker(string first, string last, string ssn,
           decimal earnings, decimal rate)
            : base(first, last, ssn)
        {
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
