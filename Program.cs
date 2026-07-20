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

            // 6. Temperature Converter
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);

            if (celsius < 10)
            {
                Console.WriteLine("Cold");
            }
            else if (celsius <= 30)
            {
                Console.WriteLine("Mild");
            }
            else
            {
                Console.WriteLine("Hot");
            }


            // 7. Movie Ticket Pricing
            Console.Write("Enter age: ");
            int mAge = Convert.ToInt32(Console.ReadLine());

            if (mAge <= 12)
            {
                Console.WriteLine("Child ticket: 2.000 OMR");
            }
            else if (mAge <= 59)
            {
                Console.WriteLine("Adult ticket: 5.000 OMR");
            }
            else
            {
                Console.WriteLine("Senior ticket: 3.000 OMR");
            }


            // 8. Restaurant Bill
            Console.Write("Enter bill total: ");
            double total = Convert.ToDouble(Console.ReadLine());

            Console.Write("Are you member? (yes/no): ");
            string isMember = Console.ReadLine();

            double discount = 0;
            if (total > 20 && isMember == "yes")
            {
                discount = total * 0.15;
            }

            double finalPay = total - discount;
            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Total to pay: " + finalPay);


            // 9. Day Name Finder
            Console.Write("Enter day number (1-7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }


            // 10. Calculator
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result: " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }


            // 11. Loan Eligibility
            Console.Write("Enter age: ");
            int lAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter monthly income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Do you have existing loan? (yes/no): ");
            string hasLoan = Console.ReadLine();

            if (lAge >= 21 && lAge <= 60 && income >= 400 && hasLoan == "no")
            {
                Console.WriteLine("Eligible for loan");
            }
            else
            {
                Console.WriteLine("Not eligible for loan");
            }


            // 12. Shipping Cost
            Console.Write("Enter region (A, B, C): ");
            string reg = Console.ReadLine();

            Console.Write("Enter weight: ");
            double w = Convert.ToDouble(Console.ReadLine());

            double cost = 0;
            switch (reg)
            {
                case "A":
                    cost = 1.000;
                    break;
                case "B":
                    cost = 3.000;
                    break;
                case "C":
                    cost = 7.000;
                    break;
                default:
                    Console.WriteLine("Invalid region");
                    break;
            }

            if (w > 10)
            {
                cost = cost + 5.000;
            }
            else if (w > 5)
            {
                cost = cost + 2.000;
            }

            Console.WriteLine("Total shipping cost: " + cost);


            // 13. Triangle Type
            Console.Write("Enter side 1: ");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 2: ");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 3: ");
            double s3 = Convert.ToDouble(Console.ReadLine());

            if (s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1)
            {
                if (s1 == s2 && s2 == s3)
                {
                    Console.WriteLine("Equilateral triangle");
                }
                else if (s1 == s2 || s1 == s3 || s2 == s3)
                {
                    Console.WriteLine("Isosceles triangle");
                }
                else
                {
                    Console.WriteLine("Scalene triangle");
                }
            }
            else
            {
                Console.WriteLine("Not a valid triangle");
            }


            // 14. Online Checkout
            Console.Write("Enter product code (1, 2, 3): ");
            int pCode = Convert.ToInt32(Console.ReadLine());

            double pPrice = 0;
            switch (pCode)
            {
                case 1:
                    pPrice = 8.500;
                    break;
                case 2:
                    pPrice = 12.000;
                    break;
                case 3:
                    pPrice = 5.000;
                    break;
            }

            Console.Write("Enter quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Has coupon? (yes/no): ");
            string coupon = Console.ReadLine();

            double subTotal = pPrice * qty;
            double pDiscount = 0;

            if (coupon == "yes" && subTotal > 20)
            {
                pDiscount = subTotal * 0.10;
            }

            double afterDisc = subTotal - pDiscount;
            double tax = afterDisc * 0.05;
            double finalPrice = afterDisc + tax;

            Console.WriteLine("Subtotal: " + subTotal);
            Console.WriteLine("Discount: " + pDiscount);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Final Total: " + finalPrice);


            // 15. Admission
            Console.Write("Enter program (S for Science, A for Arts): ");
            string prog = Console.ReadLine();

            Console.Write("Enter GPA: ");
            double gpa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter score: ");
            double score = Convert.ToDouble(Console.ReadLine());

            Console.Write("Has activity? (yes/no): ");
            string act = Console.ReadLine();

            if (prog == "S")
            {
                if (gpa >= 3.0 && score >= 75)
                {
                    Console.WriteLine("Admitted");
                }
                else if (act == "yes")
                {
                    Console.WriteLine("Conditionally Admitted");
                }
                else
                {
                    Console.WriteLine("Not Admitted");
                }
            }
            else if (prog == "A")
            {
                if (gpa >= 2.5 && score >= 60)
                {
                    Console.WriteLine("Admitted");
                }
                else if (act == "yes")
                {
                    Console.WriteLine("Conditionally Admitted");
                }
                else
                {
                    Console.WriteLine("Not Admitted");
                }
            }
            Console.ReadLine();
        }
    }
}