using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assign2
{
    public static class TriangleSolver
    {
        public static string result = "";
        public static string Analyze(int a, int b, int c)
        {
            //Placing items in an array for processing 
            int[] values = new int[3] { a, b, c };

            // keeping this as the first check in case someone passes invalid parameters that could also be a triangle type. 
            //Example: -2,-2,-2 could return Equilateral instead of Error without this check.  
            //We also have a catch all at the end that returns Error if no other condition was met.
            if (a <= 0 || b <= 0 || c <= 0)
            {
                result = "These numbers less or equal zero cannot form a triangle";
                return result;
            }
            if (a+b<c || a+c<b || c+b<a)
            {
                result = "These numbers cannot form a triangle";
                return result;
            }
            if (values.Distinct().Count() == 1) //There is only one distinct value in the set, therefore all sides are of equal length
            {
                result = "These numbers  form an Equilateral triangle";
                return result;
            }
            if (values.Distinct().Count() == 2) //There are only two distinct values in the set, therefore two sides are equal and one is not
            {
                result = "These numbers form an Isosceles triangle";
                return result;
            }
            if (values.Distinct().Count() == 3) // There are three distinct values in the set, therefore no sides are equal
            {
                result = "These numbers  form a Scalene triangle";
                return result;
            }
            else
            {
                result = "These numbers cannot form a triangle";
                return result;
            }
        }

    }
}
