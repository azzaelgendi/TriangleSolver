using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assign2
{
    public static class TriangleSolver
    {
        //Class Variables 
        public static string result = "";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">side A of the triangle </param>
        /// <param name="b">side B of the triangle</param>
        /// <param name="c">side Cof the triangle</param>
        /// <returns>result string</returns>.
        public static string Analyze(int a, int b, int c)
        {
            // array to hold the sides
            int[] values = new int[3] { a, b, c };

            // doing the check
            if (a < 0 || b < 0 || c < 0)
            {
                result = "These numbers less than zero cannot form a triangle";
                return result;
            }
            if (a == 0 || b == 0 || c == 0)
            {
                result = "These numbers  equal zero cannot form a triangle";
                return result;
            }
            if (a + b < c || a + c < b || c + b < a)
            {
                result = "These numbers cannot form a triangle";
                return result;
            }
            if (values.Distinct().Count() == 1) // all sides are of equal length
            {
                result = "These numbers  form an Equilateral triangle";
                return result;
            }
            if (values.Distinct().Count() == 2) //two sides are equal and one is not
            {
                result = "These numbers form an Isosceles triangle";
                return result;
            }
            if (values.Distinct().Count() == 3) //  no sides are equal
            {
                result = "These numbers  form a Scalene triangle";
                return result;
            }
            else
            {
                result = "Error:These entries cannot form a triangle";
                return result;
            }
        }

    }
}
