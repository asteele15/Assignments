using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._8SetofIntegers
{
    class IntegerSet
    {
        bool[] set = new bool[100];//bool set available to class
        bool[] setA = new bool[100];
        bool[] setB = new bool[100];
        
        public IntegerSet()
        {
            bool[] set = new bool[100];//initialize bool to false

            for (int i = 0; i <= 100; i++)
                set[i] = false;
        }//end integerset

        public bool inSet(int i)
        {
            return set[i];
        }//end inSet return set

        public static bool[] Union(bool[] setA, bool[] setB)//method to create a third union set
        {
            bool[] union = new bool[100];

            for(int i = 0; i <= 100; i++)//initialize union set values
            {
                if (setA[i] || setB[i])
                    union[i] = true; //return third combined set union
            }//end for

            return union;
        }//end method union

        public bool[] Intersection(bool[] setA)
        {
            bool[] intersect = new bool[100];
            
            for(int i = 0; i <= 100; i++)
                if (setA[i] && set[i])
                    intersect[i] = true;

            return intersect;
        }//end intersect method

        public void InsertElement(int num)
        {
            set[num] = true;
        }//end insert element method

        public void DeleteElement(int num)
        {
            set[num] = false;
        }//end delete element method

        public string toString() {
            string num = "";

            for(int i = 0; i<= 100; i++) { 
                if(set[i])
                    num = num + i + ", ";
            }//end for

            if (num == "")
                return "---";

            return num;

        }//end tostring

        public bool IsEqualTo(IntegerSet setB)
        {
            for (int i; i <= 100; i++ )
            {
                int x; 
                if (setB[x] == setA[i])
                    continue;
                else
                    return false;
                x++;
            }//end for
            return true;
        }//end isEqualTo method

        static void Main()
        {
            
        }//end main
    }//end class
}//end namespace
