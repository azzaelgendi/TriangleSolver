/*Prog 2070-Quality Assurance 
 * Winter 2019
 * Assignment 2 ,TriangleSolver App
 * Revision History :Azza Elgendy
 *February 11th,2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// program to analyze 3 integers if 
/// they form a valid triangle
/// check the triangle type
/// </summary>
namespace PROG2070Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            //program variables
            int sideA = 0;
            int sideB = 0;
            int sideC = 0;
            bool correct = true;
            int mainMenus = 0;
            //display menu until valid entry
            do
            {
                //Ask user for entry
                Console.WriteLine("1.Enter triangle dimensions: ");
                Console.WriteLine("2.Exit");
                Console.WriteLine("___________________________________________");
                try
                {
                    //read the user entry
                    mainMenus = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    //error message
                    Console.WriteLine("Error:Please Enter an integer ");
                }
                //check menu 
                switch (mainMenus)
                {
                    //ask user to enter 3 values then read the user entry
                    case 1:
                        try
                        {
                            //Side A
                            Console.WriteLine("Please Enter the First side");
                            sideA = int.Parse(Console.ReadLine());
                            //Side B
                            Console.WriteLine("Please Enter the Second side");
                            sideB = int.Parse(Console.ReadLine());
                            //Side C
                            Console.WriteLine("Please Enter the Third side");
                            sideC = int.Parse(Console.ReadLine());

                        }
                        catch (Exception)
                        {
                            //Error if any side is not valid integer
                            Console.WriteLine("Error in  the data side");
                        }
                        //analze the sides
                        TriangleSolver.Analyze(sideA, sideB, sideC);
                        //return the result
                        Console.WriteLine(TriangleSolver.result);
                        break;
                    case 2:
                        //Exit the program
                        Environment.Exit(0);
                        break;
                    default:
                        //if the user provide no correct menu number
                        Console.WriteLine("Your entry wasnot correct !try again ");
                        Console.WriteLine("___________________________________________");
                        break;
                }
            } while (correct);//repeat the menue until valid entry
            Console.Read();
        }
    }
}
