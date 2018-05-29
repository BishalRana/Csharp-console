using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileAndDoWhileExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "to help old lady";
            int numbGuess = 0;
            int rightAttempts = 0;
           

            Console.WriteLine("Why did man go across the road?");
            string input = Console.ReadLine();
            numbGuess++;

            while((!answer.Equals(input) && (numbGuess < 3)))
            {
                Console.WriteLine("You have "+(3 - numbGuess)+" guess left.");
                Console.WriteLine("Why did man go across the road?");
                input = Console.ReadLine().ToLower();               
                numbGuess++;
            }

          

            Console.WriteLine("Answer : "+answer);

            numbGuess = 0;            
            answer = "they are eating icecream";
            Console.WriteLine("Another riddle.");

            do
            {
                Console.WriteLine("You have " + (3 - numbGuess) + " guess left.");
                Console.WriteLine("What are children doing?");
                input = Console.ReadLine();              
                numbGuess++;
            } while (!answer.Equals(input) && (numbGuess < 3));

            Console.WriteLine("Answer : "+answer);           

        }
    }
}
