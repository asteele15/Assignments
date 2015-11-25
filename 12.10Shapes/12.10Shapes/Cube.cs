using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10Shapes
{
    class Cube : ThreeDimensional
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

        public override double SArea()
        {
            double area;
            area = (side * side) * 6;

            return area;
        }//end surface area

        public override double Volume()
        {
            double volume;
            volume = side * side * side;

            return volume; 
        }//end volume
    }//end class
}//end namespace
