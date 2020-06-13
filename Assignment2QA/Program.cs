using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2QA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sides = new int[3];
            bool exit = false;
            bool typo = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("------------------ MENU ------------------" + Environment.NewLine
                     + "Type 1 to enter triangle dimension" + Environment.NewLine
                     + "Type 2 to exit" + Environment.NewLine
                     + "----------------------------------------------");

                do
                {
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            EnterTriangleDimensions();
                            break;
                        case "2":
                            Console.WriteLine("Bye Bye");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Not a valid menu option, try again.");
                            typo = true;
                            break;
                    }
                } while (typo);

            } while (!exit);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("(press enter to close)");
            Console.ReadLine();

            void EnterTriangleDimensions() {
                for (int i = 0; i < 3; i++) {
                    Console.WriteLine("Enter a value for the {0} side", i+1);
                    sides[i] = EnterSide();
                }

                Console.WriteLine(TriangleSolver.Analyze(sides[0], sides[1], sides[2]));
            }

            int EnterSide() {
                string input = "";
                int output = 0;
                do
                {
                    Console.WriteLine("Please enter an integer non-decimal number");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out output));

                return output;
            }
        }
    }
}
