using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Two options: one number or two numbers mathematic operation.\n"
                +"For options 1 ,enter 'First'\n"
                +"For options 2 ,enter 'Second'.");
            string optType = Console.ReadLine().ToLower();

            if (optType == "first")
            {
                Console.WriteLine(FirstOptionOperation());
            }
            else
            {
                Console.WriteLine(SecondOptionOperation());
            }
           
        }

        static string FirstOptionOperation()
        {
            decimal firstNumber;
            string operatorType;
            decimal secondNumber;
            decimal res;

            Console.WriteLine("Arithemetic Operation.Please give two numbers and sign opertors like /,*X+,-");

            Console.WriteLine("Enter first number.");
            firstNumber = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the sign");
            operatorType = Console.ReadLine();

            Console.WriteLine("Enter second number");
            secondNumber = Convert.ToDecimal(Console.ReadLine());

            switch (operatorType)
            {
                case "/":
                    res = Division(firstNumber, secondNumber);
                    break;
                case "X":
                case "x":
                case "*":
                    res = Multiplication(firstNumber, secondNumber);
                    break;
                case "+":
                    res = Addition(firstNumber, secondNumber);
                    break;
                case "-":
                    res = Subtraction(firstNumber, secondNumber);
                    break;
                default:
                    res = 0;
                    break;
            }

            return firstNumber + " " + operatorType + " " + secondNumber + " = " + res;
        }

        static string SecondOptionOperation()
        {
            decimal firstNumber;
            string operationType;
            decimal res;
            
            Console.WriteLine("Enter first number.");
            firstNumber = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Choose the operation type.\n"
                + "Square\nSquare root\nTan");
            operationType = Console.ReadLine().ToLower();

            switch (operationType)
            {
                case "square":
                    res = Square(firstNumber);
                    break;
                case "square root":
                    res = SquareRoot(firstNumber);
                    break;
                case "tan":
                    res = Tang(firstNumber);
                    break;
                default:
                    res = 0;
                    break;
            }

            return "\nNumber :" + firstNumber + "\n Operation : " + operationType + ".\n Res = " + res;

        }

        static decimal Division(decimal firstNumber, decimal secondNumber)
        {           
            return firstNumber / secondNumber;            
        }

        static decimal Multiplication(decimal firstNumber, decimal secondNumber)
        {

            return firstNumber * secondNumber;
            
        }

        static decimal Subtraction(decimal firstNumber, decimal secondNumber)
        {

            return firstNumber - secondNumber;
            
        }

        static decimal Addition(decimal firstNumber, decimal secondNumber)
        {

            return firstNumber + secondNumber;
            
        }

        static decimal SquareRoot(decimal firstNumber)
        {
            return Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(firstNumber)));            
        }

        static decimal Square(decimal firstNumber)
        {
            return  firstNumber * firstNumber;
            
        }

        static decimal Tang(decimal firstNumber)
        {
            return  Convert.ToDecimal(Math.Tan(Convert.ToDouble(firstNumber)));            
        }
    }
}
