using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10Shapes
{
    class Square : TwoDimensional
    {
        public double side
        {
            //get value
            get
            {
                return side;
            }
            set
            {
                if (value >= 0)
                    side = value;
                else
                    throw new ArgumentOutOfRangeException("side", value, "side must be >= zero.");
            }//end set
        }//end side

        public override double Area()
        {
            //calc area of square
            double area;
            area = side * side;

            return area;
        }//end area

        public override double perimeter()
        {
            double perimeter;
            perimeter = side * 4;

            return perimeter;
        }// end perimeter
        
    }//end class
}//end namespace
