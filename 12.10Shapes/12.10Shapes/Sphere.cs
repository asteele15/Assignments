using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10Shapes
{
    class Sphere : ThreeDimensional
    {
        public double radius
        {
            //get value greater than zero for radius of circle
            get
            {
                return radius;
            }//end get
            set
            {
                if (value >= 0)
                    radius = value;
                else
                    throw new ArgumentOutOfRangeException("radius", value, "Radius must be greater than zero.");
            } //end set
        }//end radius

        public override double SArea()
        {
            //calculate area
            double area;
            area = 4 * Math.PI * (radius * radius);

            return area;
            
        }//end area

        public override double Volume()
        {
            //calculate volume
            double volume;
            volume = (4 / 3) * Math.PI * (radius * radius);

            return volume;
            throw new NotImplementedException();
        }//end volume
    }//end class
}//end namespace
