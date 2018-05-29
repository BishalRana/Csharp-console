using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndFieldsexercise
{

    public class Car
    {
        //non static or instance fields
        public string model;
        public int price;
        public string mileage;

        //static field
        public static int numberOfCars = 0;
        
        

        public void AddDetailsOfCar(string model , int price,string mileage)
        {
            this.model = model;
            this.price = price;
            this.mileage = mileage;
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            //add cars data
            Car fiesta = new Car();
            fiesta.model = "FIESTA-12H0";
            fiesta.price = 100500;
            fiesta.mileage = "60m/h";


            Car.numberOfCars++;

            Car vauxhall = new Car();
            vauxhall.model = "VAU-HUJ679";
            vauxhall.price = 30000;
            vauxhall.mileage = "56m/h";

            Car.numberOfCars++;

            Car ferrari = new Car();
            ferrari.model = "FERR-HJU23";
            ferrari.price = 450000;
            ferrari.mileage = "70m/h";

            Car.numberOfCars++;

            Console.WriteLine("total number of cars " + Car.numberOfCars);

            Console.WriteLine("");
            Console.WriteLine("Model : " + fiesta.model);
            Console.WriteLine("Mileage : " + fiesta.mileage);
            Console.WriteLine("Price : " + fiesta.price.ToString("£##"));

            Console.WriteLine("");
            Console.WriteLine("Model : " + ferrari.model);
            Console.WriteLine("Mileage : " + ferrari.mileage);
            Console.WriteLine("Price £{0}: " , ferrari.price);

            Console.WriteLine("");
            Console.WriteLine("Model : " + vauxhall.model);
            Console.WriteLine("Mileage : " + vauxhall.mileage);
            Console.WriteLine("Price : " + vauxhall.price.ToString("£##"));

        }
    }
}
