using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serving Dwarf
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

            string dinner;
            string drink;
            for (int i = 0;i<sevenDwarves.Length;i++)
            {
                Console.WriteLine( "Here is your dinner "+ sevenDwarves[i]);
            }

            Console.WriteLine("\n");

            foreach (string dwarf in sevenDwarves)
            {
                Console.WriteLine("Here is your dinner "+dwarf);
            }

            Console.WriteLine("\n");



            foreach(string dwarf in sevenDwarves)
            {
                Console.WriteLine("What would you like for dinner,"+dwarf+"?");
                dinner = Console.ReadLine();
                Console.WriteLine(dwarf + " your "+dinner+" is ready");
            }

            Console.WriteLine("\n");

            foreach (string dwarf in sevenDwarves)
            {
                Console.WriteLine("What would you like for drink," + dwarf + "?");
                drink = Console.ReadLine();
                Console.WriteLine(dwarf + " your " + drink + " is ready");
            }

            Console.WriteLine("\n");

            foreach (string dwarf in sevenDwarves)
            {
                Console.WriteLine("What would you like for dinner," + dwarf + "?");
                dinner = Console.ReadLine();
                Console.WriteLine("What would you like for drink," + dwarf + "?");
                drink = Console.ReadLine();
                Console.WriteLine(dwarf + " here's your " + dinner +" and "+drink+ ".");
            }

            /*
            Console.WriteLine("\n");

            string[] dinner = { "roast chicken", "fry rice", " chips", "fish", "Hamnburger", "Chicken grill", "Kebab" };
            string[] drink = { "coke", "pepsi", "sparkling water", "lemonade", "soda water", "mango juice", "banana lassy" };

            
            for (int i = 0;i<sevenDwarves.Length;i++ )
            {
                Console.WriteLine(sevenDwarves[i] + " ,your " + dinner[i] + " and " + drink[i] + " ready");
            }
            */
        }
    }
}
