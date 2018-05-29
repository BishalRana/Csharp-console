using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberToGuess = 10;
            var userinput = 0;
            Boolean correct = false;
            char finished = 'N';
            Random randomNumber = new Random();
            var secondNumberToGuess = randomNumber.Next(0, 50);

            Console.WriteLine("Enter the number");

            userinput = Convert.ToInt32(Console.ReadLine());

            if (numberToGuess > userinput)
            {
                Console.WriteLine("Try greater number");

            }
            else if (numberToGuess < userinput)
            {
                Console.WriteLine("Try smaller number");
            }

            else
            {
                Console.WriteLine("Your guess is correct");
            }

            Console.WriteLine("Enter the another number");

            do
            {
                try
                {
                    userinput = Convert.ToInt32(Console.ReadLine());

                    // check if entered number is smaller than my number
                    if (secondNumberToGuess > userinput)
                    {
                        Console.WriteLine("Try greater number");

                    }
                    // check if entered number is greater than my number 
                    else if (secondNumberToGuess < userinput)
                    {
                        Console.WriteLine("Try smaller number");
                    }
                    // print out the entered number is correct
                    else
                    {
                        correct = true;
                        Console.WriteLine("Your quess is correct");
                    }

                    if (!correct)
                    {
                        Console.WriteLine("Do you want to enter another number? (Y/N)");
                        finished = Convert.ToChar(Console.ReadLine().ToUpper());
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while ((secondNumberToGuess != userinput) && (finished != 'N'));


        }
    }
}
