using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static int global = 9;
        static void Main(string[] args)
        {
            //the simplest c# program
            Console.WriteLine("Hello,world");
            int global = 8;      
            method1();            
        }

        static void method1()
        {
            Console.WriteLine(global);
        }
    }
}
