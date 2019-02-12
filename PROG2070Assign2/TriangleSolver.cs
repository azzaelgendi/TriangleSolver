/*Prog 2070-Quality Assurance 
 * Winter 2019
 * Assignment 1 ,TriangleSolver Class
 * Revision History :Azza Elgendy
 *February 11th,2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Class to check 3 integer ,
/// if they form a triangle
/// </summary>
namespace PROG2070Assign2
{/// <summary>
/// static class
/// </summary>
    public static class TriangleSolver
    {
        //Class Variables 
        public static string result = "";
        /// <summary>
        /// Analyze method takes three integers 
        /// returns a string
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
            //less than zero 
            if (a < 0 || b < 0 || c < 0)
            {
                result = "These numbers less than zero cannot form a triangle";
                return result;
            }
            //equal zero
            else if (a == 0 || b == 0 || c == 0)
            {
                result = "These numbers  equal zero cannot form a triangle";
                return result;
            }
            //if more than zero valid entry
            //sum of any two sides must be larger than the third one
            //cannot form a triangle if sum of any two sides less than the third
            else
            {
                if (a + b < c || a + c < b || c + b < a)
                {
                    result = "These numbers cannot form a triangle";
                    return result;
                }
                else
                {
                    // all sides are of equal length return Equilateral triangle
                    if (values.Distinct().Count() == 1)
                    {
                        result = "These numbers  form an Equilateral triangle";
                        return result;
                    }
                    //two sides are equal and one is not return Isosceles triangle
                    if (values.Distinct().Count() == 2)
                    {
                        result = "These numbers form an Isosceles triangle";
                        return result;
                    }
                    //  no sides are equal return a Scalene triangle
                    if (values.Distinct().Count() == 3)
                    {
                        result = "These numbers  form a Scalene triangle";
                        return result;
                    }
                    // for any other errors
                    else
                    {
                        result = "Error:These entries cannot form a triangle";
                        return result;
                    }
                }
            }
        }

    }
}
