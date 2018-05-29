using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayException
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameArray = new String[3];
            int dividend = 30;
            int divider = 0;

            try
            {
                for (int i = 0; i <= nameArray.Length; i++)
                {
                    nameArray[i] = "name" + i;
                    Console.WriteLine("The value at {0} {1} {2} {3}", "array[",i,"] is ", nameArray[i]);
                }
            }                 
            catch (IndexOutOfRangeException iore)
            {
                Console.WriteLine("Pushing array to its limit");
                Console.WriteLine(iore.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                Console.WriteLine(dividend/divider);
            }
            catch (DivideByZeroException dze)
            {
                Console.WriteLine(dze.Message);
                Console.WriteLine("{0}/{1} gives an error ", dividend, divider);
            }
        }
    }
}
