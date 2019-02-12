/*Prog 2070-Quality Assurance 
 * Winter 2019
 * Assignment 2 ,TriangleSolverTest
 * Revision History :Azza Elgendy
 *February 11th,2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

/// <summary>
/// test class to test triangle solver class
/// Nunit test
/// </summary>
namespace PROG2070Assign2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        /// <summary>
        /// Test sides as 3 equal integers
        /// compare the result with the expected result
        /// </summary>
        [Test]
        public void AnalyzeEquilateralTest()
        {
            TriangleSolver.Analyze(4, 4, 4);
            Assert.AreEqual(TriangleSolver.result, "These numbers  form an Equilateral triangle");
        }
        /// <summary>
        /// test sides as two are equal 
        /// compare the result with the expected result
        /// </summary>
        [Test]
        public void AnalyzeIsoscelesTest()
        {
            TriangleSolver.Analyze(4, 4, 5);
            Assert.AreEqual(TriangleSolver.result, "These numbers form an Isosceles triangle");
        }
        /// <summary>
        /// test sides that cannot form a triangle
        /// compare the result with the expected result
        /// </summary>
        [Test]
        public void AnalyzeNotTriangleTest()
        {
            TriangleSolver.Analyze(50, 4, 5);
            Assert.AreEqual(TriangleSolver.result, "These numbers cannot form a triangle");
        }
        /// <summary>
        /// test sides with negative values that cannot form a triangle
        /// compare the result with the expected result
        /// </summary>
        [Test]
        public void AnalyzeNegativeVauesTest()
        {
            TriangleSolver.Analyze(0, -4, 5);
            Assert.AreEqual(TriangleSolver.result, "These numbers less than zero cannot form a triangle");
        }
        /// <summary>
        /// test 3 valid integers which are equal
        /// compare the result with the expected result
        /// </summary>
        [Test]
        public void AnalyzeScaleneTest()
        {
            TriangleSolver.Analyze(4, 5, 6);
            Assert.AreEqual(TriangleSolver.result, "These numbers  form a Scalene triangle");
        }
        /// <summary>
        /// test sides with zero values that cannot form a triangle
        /// compare the result with the expected result
        /// </summary>
        [Test]
        public void AnalyzeZeroTest()
        {
            TriangleSolver.Analyze(0, 0, 6);
            Assert.AreEqual(TriangleSolver.result, "These numbers  equal zero cannot form a triangle");
        }
    }
}
