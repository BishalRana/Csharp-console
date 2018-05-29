using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int size=0;
            decimal[] number = new decimal[size];
            decimal[] n = new decimal(size);
            */
            //Console.WriteLine(Average());            
            totalOfTwoDimensionalArray();
        }

        static string Average()
        {
            double[] numberArrays = new double[5];
            double sum = 0;
            int inputNumber = 1;
            for (int i = 0; i < numberArrays.Length; i++)
            {
                Console.WriteLine("Enter your " +inputNumber+ " number ");
                numberArrays[i] = Convert.ToDouble(Console.ReadLine());
                inputNumber++;
            }
            
            foreach (double number in numberArrays)
            {
                sum = sum + number;
            }

            return "Average : "+sum / numberArrays.Length;
        }

        static void totalOfTwoDimensionalArray()
        {
            Console.WriteLine("Two dimensional array demostration");
            double[,] numbers = new double[4, 5];
            double sum = 0;
            double rowSum = 0;
            double columnSum = 0;
            int rowNumber = 1;
            int columnNumber = 1;
            Random random = new Random();
            
            //entering the 20 numbers
            for (int i = 0;i< numbers.GetLength(0); i++)
            {
                for (int j = 0;j<numbers.GetLength(1);j++)
                {
                    //Console.WriteLine("Enter the number");
                    //numbers[i, j] = Convert.ToDouble(Console.ReadLine());
                    numbers[i, j] = random.Next(1,11);
                }
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write("{0}\t", numbers[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < numbers.GetLength(1); i++)
            {                
                columnSum = 0;
                
                for (int j = 0;j<numbers.GetLength(0);j++)
                {
                    columnSum = columnSum + numbers[j, i];                   
                }

                Console.WriteLine("\nTotal of column " + columnNumber + " is " + columnSum);
                columnNumber++;                                   

            }

             for (int i = 0; i < numbers.GetLength(0); i++)
            {
                rowSum = 0;
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    rowSum = rowSum + numbers[i, j];
                }
                Console.WriteLine("\nTotal of row " + rowNumber + " : " + rowSum);
                rowNumber++;
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    //Console.WriteLine(numbers[i, j]);
                    sum = sum + numbers[i, j];
                }
            }
            
             Console.WriteLine("The overall total is "+sum);
        }
    }
}
