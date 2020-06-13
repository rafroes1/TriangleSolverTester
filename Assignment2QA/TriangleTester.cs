using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment2QA
{
    [TestFixture]
    class TriangleTester
    {
        [Test, Category("pass")]
        /*
            First set of test cases tests if it is a triangle using low parameters values
        */
        [TestCase(3, 3, 3, "It is a Equilateral Triangle")]
        [TestCase(3, 4, 4, "It is a Isosceles Triangle")]
        [TestCase(3, 4, 5, "It is a Scalene Triangle")]
        /*
            First set of test cases tests if it is a triangle using high parameters values
        */
        [TestCase(300, 300, 300, "It is a Equilateral Triangle")]
        [TestCase(300, 400, 400, "It is a Isosceles Triangle")]
        [TestCase(300, 400, 500, "It is a Scalene Triangle")]
        /*
            Third set of test cases tests when it is not a triangle, using low and high parameters value
        */
        [TestCase(3, 4, 10, "Does not form a triangle")]
        [TestCase(300, 400, 1000, "Does not form a triangle")]

        /*
            Fourth set of test cases tests when it is not a triangle, using negative integers for each case of triangle type
        */
        [TestCase(-3, -3, -3, "Does not form a triangle")]
        [TestCase(-3, -4, -4, "Does not form a triangle")]
        [TestCase(-3, -4, -5, "Does not form a triangle")]
        public void Analyze(int sideA, int sideB, int sideC, string expectedOutput) {
            Assert.AreEqual(expectedOutput, TriangleSolver.Analyze(sideA, sideB, sideC));
        }
    }
}
