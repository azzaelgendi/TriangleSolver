using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace PROG2070Assign2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [Test]
        public void AnalyzeEquilateralTest()
        {
            TriangleSolver.Analyze(4, 4, 4);
            Assert.Equals(TriangleSolver.result, "These numbers  form an Equilateral triangle");
        }

        [Test]
        public void AnalyzeIsoscelesTest()
        {
            TriangleSolver.Analyze(4, 4, 5);
            Assert.Equals(TriangleSolver.result, "These numbers form an Isosceles triangle");
        }

        [Test]
        public void AnalyzeNotTriangleTest()
        {
            TriangleSolver.Analyze(50, 4, 5);
            Assert.Equals(TriangleSolver.result, "These numbers cannot form a triangle");
        }

        [Test]
        public void AnalyzeNegativeVauesTest()
        {
            TriangleSolver.Analyze(0, -4, 5);
            Assert.Equals(TriangleSolver.result, "These numbers less than zero cannot form a triangle");
        }

        [Test]
        public void AnalyzeScaleneTest()
        {
            TriangleSolver.Analyze(4, 5, 6);
            Assert.Equals(TriangleSolver.result, "These numbers  form a Scalene triangle");
        }
        [Test]
        public void AnalyzeZeroTest()
        {
            TriangleSolver.Analyze(0, 0, 6);
            Assert.Equals(TriangleSolver.result, "These numbers  equal zero cannot form a triangle");
        }
    }
}
