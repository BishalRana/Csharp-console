using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonstaticMethodsObject
{
    public class Car
    {
        //non static field
        public string model;
        public int price;
        public string mileage;
        public bool sold;
        
        //static field
        public static int numberOfCars = 0;
       

        //method that adds car details in the fields
        public void AddDetailsOfCar(string model, int price, string mileage,bool sold)
        {
            this.model = model;
            this.price = price;
            this.mileage = mileage;
            this.sold = sold;
            Car.numberOfCars++;
        }

        // display the car info for an individual car
        public void DisplayCarInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("The Details of the car:\nModel:{0} \nMileage:{1} \nPrices:{2:N2}"
                , this.model,this.mileage,this.price);

            if (this.sold)
            {
                Console.WriteLine("This car has been sold");
            }
            else
            {
                Console.WriteLine("This car is available for sell.");
            }
        }

        public static void DisplayListOfCars(List<Car> listOfCars)
        {
            foreach (Car car in listOfCars)
            {
                car.DisplayCarInfo();
            }
        }

        public void sell(int price)
        {
            this.sold = true;
            this.price = price;
            Car.numberOfCars--;
        }

        public static void CalculateValueOfSales(List<Car>  allCars)
        {
            int totalSalesValue = 0;

            foreach(Car car in allCars)
            {
                if (car.sold)
                {
                    totalSalesValue += car.price;
                }
            }
            Console.WriteLine("The total value of sale is £{0:N0}", totalSalesValue);
        }

        public static void CalculateValueOfStock(List<Car> allCars)
        {
            int totalStockValue = 0;
            foreach (Car car in allCars)
            {
                if (!car.sold)
                {
                    totalStockValue += car.price;
                }                
            }
            Console.WriteLine("The total value of stock is £{0:N0}",totalStockValue);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> allCars = new List<Car>();

            Car fiesta = new Car();
            fiesta.AddDetailsOfCar("FIESTA-12H0", 100500, "60m/h",false);
            allCars.Add(fiesta);       

            Car vauxhall = new Car();
            vauxhall.AddDetailsOfCar("VAU-HUJ679", 30000, "56m/h",false);
            allCars.Add(vauxhall);
           
            Car ferrari = new Car();
            ferrari.AddDetailsOfCar("FERR-HJU23", 450000, "70m/h",false);
            allCars.Add(ferrari);

            Console.WriteLine("***********Info of cars before selling**********");
            Car.DisplayListOfCars(allCars);
            Console.WriteLine("**************************************************");

            fiesta.sell(50000);
            vauxhall.sell(20000);

            Console.WriteLine("");
            Console.WriteLine("***********Info of cars after selling**********");
            Car.DisplayListOfCars(allCars);
            Console.WriteLine("**************************************************");

            Console.WriteLine("");
            Console.WriteLine("***********Value of stock and sales after selling the car **********");
            Car.CalculateValueOfSales(allCars);
            Car.CalculateValueOfStock(allCars);
            Console.WriteLine("********************************************************************");                                                
        }
    }
}
