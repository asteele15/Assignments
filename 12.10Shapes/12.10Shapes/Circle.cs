using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10Shapes
{
    class Circle : TwoDimensional
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

        public double Area()
        { 
            //calculate area
            double area; 
            area = (radius * radius) * Math.PI;

            return area;
                      
        }//end Area

        public double Circumference()
        {
            double circumference;
            circumference = (radius * 2) * Math.PI;

            return circumference;
        }//end circumference 

      }//end class
}//end namespace
