﻿/*Prog 2070-Quality Assurance 
 * Winter 2019
 * Assignment 1 ,TriangleSolver App
 * Revision History :Azza Elgendy
 *February 11th,2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            bool sidesBool = true;
            int mainMenus = 0;

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


                switch (mainMenus)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Please Enter the First side");
                            sideA = int.Parse(Console.ReadLine());

                            Console.WriteLine("Please Enter the Second side");
                            sideB = int.Parse(Console.ReadLine());

                            Console.WriteLine("Please Enter the Third side");
                            sideC = int.Parse(Console.ReadLine());

                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Error in  the data side");
                        }

                        TriangleSolver.Analyze(sideA, sideB, sideC);
                        Console.WriteLine(TriangleSolver.result);
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Your entry wasnot correct !try again ");
                        Console.WriteLine("___________________________________________");

                        break;
                }


            } while (correct);



            Console.Read();
        }
    }
}
