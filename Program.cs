using System;

namespace CsharpSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////
            Console.WriteLine("== [1] Personal Info ==");
            string empName = "Abdulraheem";
            int userAge = 21;
            double empHeight = 1.65;
            bool studentStatus = true;

            Console.WriteLine("Name: " + empName + ", Age: " + userAge + ", Height: " + empHeight + ", Student: " + studentStatus);
            Console.WriteLine();


            /////////////////////////////////////////////////////////////////
            Console.WriteLine("== [2] Rectangle Calc ==");
            Console.Write("Enter length: ");
            double L = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width: ");
            double W = double.Parse(Console.ReadLine());

            double rArea = L * W;
            double rPerimeter = 2 * (L + W);

            Console.WriteLine("Calculated Area -> " + rArea);
            Console.WriteLine("Calculated Perimeter -> " + rPerimeter);
            Console.WriteLine();


            /////////////////////////////////////////////////////////////////
            Console.WriteLine("== [3] Even / Odd ==");
            Console.Write("Type any whole number: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            if (inputNum % 2 == 0)
            {
                Console.WriteLine("Result: Even");
            }
            else
            {
                Console.WriteLine("Result: Odd");
            }
            Console.WriteLine();


            ///////////////////////////////////////////////////////////////
            Console.WriteLine("== [4] Vote Check ==");
            Console.Write("How old are you? ");
            int myAge = int.Parse(Console.ReadLine());

            Console.Write("Do you have a National ID? (yes/no): ");
            string idAnswer = Console.ReadLine().Trim().ToLower();

            bool isIdValid = (idAnswer == "yes");

            if (myAge >= 18 && isIdValid)
            {
                Console.WriteLine("Status: You can vote.");
            }
            else
            {
                Console.WriteLine("Status: Not allowed to vote.");
            }
            Console.WriteLine();


            /////////////////////////////////////////////////////////////////
            Console.WriteLine("== [5] Grades Lookup ==");
            Console.Write("Enter Grade (A-F): ");
            char userGrade = char.Parse(Console.ReadLine().ToUpper());

            switch (userGrade)
            {
                case 'A':
                    Console.WriteLine("Result -> Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Result -> Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Result -> Good");
                    break;
                case 'D':
                    Console.WriteLine("Result -> Pass");
                    break;
                case 'F':
                    Console.WriteLine("Result -> Fail");
                    break;
                default:
                    Console.WriteLine("Result -> Invalid grade entered");
                    break;
            }
            Console.WriteLine();

            /////////////////////////////////////////////////////////////////
            Console.WriteLine("=================================");
            Console.WriteLine("Done executing tasks.");
            Console.ReadLine();
        }
    }
}