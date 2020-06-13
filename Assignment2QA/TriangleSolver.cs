using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2QA
{
    public static class TriangleSolver
    {
        public static string Analyze(int sideA, int sideB, int sideC) {
            if (DoesFormATriangle(sideA, sideB, sideC))
            {
                return TypeOfTriangle(sideA, sideB, sideC);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "Does not form a triangle";
            }
        }

        static string TypeOfTriangle(int sideA, int sideB, int sideC)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            bool equilateral = (sideA== sideB) && (sideA == sideC);
            bool scalene = (sideA != sideB) && (sideA != sideC) && (sideB != sideC);
            if (equilateral)
            {
                return "It is a Equilateral Triangle";
            }
            else if (scalene)
            {
                return "It is a Scalene Triangle";
            }
            else
            {
                return "It is a Isosceles Triangle";
            }
        }

        static bool DoesFormATriangle(int sideA, int sideB, int sideC)
        {
            bool conditionA = sideA + sideB > sideC;
            bool conditionB = sideA + sideC > sideB;
            bool conditionC = sideB + sideC > sideA;

            if (conditionA && conditionB && conditionC)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
