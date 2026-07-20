using System;

namespace CsharpSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1 - Personal Info Card
            string name = "Abdulraheem";
            int age = 21;
            double height = 1.65;
            bool isStudent = true;

            Console.WriteLine("Name: " + name + ", Age: " + age + ", Height: " + height + ", Student: " + isStudent);


            // TASK 2 - Rectangle Calculator
            Console.Write("Please Enter Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Please Enter Width: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);


            // TASK 3 - Even or Odd Checker
            Console.Write("Please Enter a Whole Number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }


            // TASK 4 - Voting Eligibility
            Console.Write("Please Enter Your Age: ");
            int voterAge = int.Parse(Console.ReadLine());

            Console.Write("Do you have valid ID? (yes/no): ");
            string hasId = Console.ReadLine();

            if (voterAge >= 18 && hasId == "yes")
            {
                Console.WriteLine("Eligible to vote");
            }
            else
            {
                Console.WriteLine("Not eligible to vote");
            }


            // TASK 5 - Grade Letter Lookup
            Console.Write("Please Enter Grade Letter: ");
            char grade = char.Parse(Console.ReadLine());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Pass");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }

           
            Console.ReadLine();
        }
    }
}