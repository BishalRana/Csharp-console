using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Car
    {
        //non static field
        public string model;
        public int price;
        public string mileage;
        public bool sold;
        public int numberOfDoors;

        //static field
        public static int numberOfCars = 0;


        //constructor for creating a car
        public Car(string model, int price, string mileage, bool sold)
        {
            this.model = model;
            this.price = price;
            this.mileage = mileage;
            this.sold = sold;
            this.numberOfDoors = 4;
            numberOfCars++;
        }

        //constructor for creating a car with extra parameter
        public Car(string model, int price, string mileage, bool sold,int numberOfDoors)
        {
            this.model = model;
            this.price = price;
            this.mileage = mileage;
            this.sold = sold;
            this.numberOfDoors = numberOfDoors;
            numberOfCars++;
        }

        // display the car info for an individual car
        public void DisplayCarInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("The Details of the car:\nModel:{0} \nMileage:{1} \nNumber of doors:{2} \nPrice:{3:N0}"
                , this.model, this.mileage,this.numberOfDoors, this.price);

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
            numberOfCars--;
        }

        public static void CalculateValueOfSales(List<Car> allCars)
        {
            int totalSalesValue = 0;

            foreach (Car car in allCars)
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
            Console.WriteLine("The total value of cars still in stock is £{0:N0}", totalStockValue);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> allCars = new List<Car>();

            Car fiesta = new Car("FIESTA-12H0", 100500, "60m/h", false);           
            allCars.Add(fiesta);

            Car vauxhall = new Car("VAU-HUJ679", 30000, "56m/h", false);            
            allCars.Add(vauxhall);

            Car ferrari = new Car("FERR-HJU23", 450000, "70m/h", false);            
            allCars.Add(ferrari);

            Car racingCar = new Car("RAC-HJ$5",40000,"60m/h",false,2);
            allCars.Add(racingCar);

            Car adventureCar = new Car("ADV-JHJI", 500000, "30m/h", false, 2);
            allCars.Add(adventureCar);


            Console.WriteLine("***********Info of cars before selling**********");
            Car.DisplayListOfCars(allCars);
            Console.WriteLine("**************************************************");

            fiesta.sell(50000);
            vauxhall.sell(20000);
            adventureCar.sell(450000);

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
