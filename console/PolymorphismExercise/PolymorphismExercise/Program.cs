using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public class Vehicle
    {
        //non static fields
        public int price;
        public string model;
        public string mileage;
        public int numberOfDoors;
        public bool sold;

        public Vehicle()
        {

        }


        public Vehicle(string model, string mileage, int price, bool sold)
        {
            this.model = model;
            this.mileage = mileage;
            this.price = price;
            this.sold = sold;
            this.numberOfDoors = 4;
        }

        public Vehicle(string model, string mileage, int price, bool sold, int numberOfDoors)
        {
            this.model = model;
            this.mileage = mileage;
            this.price = price;
            this.sold = sold;
            this.numberOfDoors = numberOfDoors;
        }

        public virtual void NumberOfWheels()
        {
            Console.WriteLine("Six wheels vehicle");
        }

        public void sell(int price)
        {
            this.price = price;
            this.sold = true;
        }

        public void DisplayVehicleInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("Model:{0} \nPrice : £{1:N0} " +
                              "\nMileage:{2}", this.model, this.price
                              , this.mileage);
        }

        public void DisplayAllVehicleInfo(List<Vehicle> vehicles)
        {
            string type = "";
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayVehicleInfo();
                if (vehicle is Car)
                {
                    type = "car";
                }
                else
                {
                    type = "motor cycle";
                }

                if (vehicle.sold)
                {
                    Console.WriteLine("This {0} has been sold", type);
                }
                else
                {
                    Console.WriteLine("This {0} is not sold", type);
                }
            }
        }
    }

    public class Car : Vehicle
    {
        static int numberOfCalsforSale = 0;
        static int totalCarsSaleValue = 0;

        public Car()
        {

        }

        public Car(string model, string mileage, int price, bool sold) : base(model, mileage, price, sold)
        {
            numberOfCalsforSale++;
        }

        public Car(string model, string mileage, int price, bool sold, int numberOfDoors) :
        base(model, mileage, price, sold, numberOfDoors)
        {
            numberOfCalsforSale++;
        }

        public override void  NumberOfWheels()
        {
            Console.WriteLine("Four wheels car");
        }

        public void sellCar(int price)
        {
            sell(price);
            numberOfCalsforSale--;
            totalCarsSaleValue += price;
        }
        // display the car info for an individual car
        public void DisplayCarInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("The Details of the car:\nModel:{0} \nMileage:{1} \nNumber of doors:{2} \nPrice:{3:N0}"
                , this.model, this.mileage, this.numberOfDoors, this.price);

            if (this.sold)
            {
                Console.WriteLine("This car has been sold");
            }
            else
            {
                Console.WriteLine("This car is available for sell.");
            }
        }


        public static void DisplayListOfCars(List<Vehicle> vehicles)
        {
            foreach (Vehicle vehicle in vehicles)
            {

                if (vehicle is Car)
                {
                    //property must be explicitly cast back to a flat to access its fields and methods from 
                    //the Car Class;
                    Car car = vehicle as Car;
                    car.DisplayCarInfo();
                }
            }
        }

        public static void CalculateValueOfStock(List<Vehicle> vehicles)
        {
            int totatlValueOfStock = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is Car)
                {
                    Car car = vehicle as Car;

                    if (!vehicle.sold)
                    {
                        totatlValueOfStock += totatlValueOfStock + vehicle.price;
                    }
                }
            }

            Console.WriteLine("Total value of car stock " + totatlValueOfStock);
        }

        public static void TotalValueOfSalesCars()
        {
            Console.WriteLine("");
            Console.WriteLine("The total values of sales of motor cylces " + totalCarsSaleValue);
        }

    }

    public class MotorCycle : Vehicle
    {
        static int numberOfMotorCycleForSale = 0;
        static int totalMotorCyclesSaleValue = 0;
        public MotorCycle()
        {

        }

        public MotorCycle(string model, string mileage, int price, bool sold) : base(model, mileage, price, sold)
        {
            numberOfMotorCycleForSale++;
        }

        public MotorCycle(string model, string mileage, int price, bool sold, int numberOfDoors) :
            base(model, mileage, price, sold, numberOfDoors)
        {
            numberOfMotorCycleForSale++;
        }

        public new void NumberOfWheels()
        {
            Console.WriteLine("2 wheels motor cycle");
        }
        public void sellMotorCycle(int price)
        {
            sell(price);
            numberOfMotorCycleForSale--;
            totalMotorCyclesSaleValue += price;
        }

        // display the car info for an individual car
        public void DisplayMotorCycleInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("The Details of the car:\nModel:{0} \nMileage:{1} \nNumber of doors:{2} \nPrice:{3:N0}"
                , this.model, this.mileage, this.numberOfDoors, this.price);

            if (this.sold)
            {
                Console.WriteLine("This  motor cycle has been sold");
            }
            else
            {
                Console.WriteLine("This motor cycle is available for sell.");
            }
        }


        public static void DisplayListOfMotors(List<Vehicle> vehicles)
        {
            foreach (Vehicle vehicle in vehicles)
            {

                if (vehicle is MotorCycle)
                {
                    //property must be explicitly cast back to a flat to access its fields and methods from 
                    //the Car Class;
                    MotorCycle motorCycle = vehicle as MotorCycle;
                    motorCycle.DisplayMotorCycleInfo();
                }
            }
        }

        public static void CalculateValueOfStock(List<Vehicle> vehicles)
        {
            int totatlValueOfStock = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is MotorCycle)
                {
                    MotorCycle motorCycle = vehicle as MotorCycle;

                    if (!vehicle.sold)
                    {
                        totatlValueOfStock += totatlValueOfStock + vehicle.price;
                    }
                }
            }

            Console.WriteLine("Total value of motorcycle stock " + totatlValueOfStock);
        }

        public static void TotalValueOfSalesMotorCylce()
        {
            Console.WriteLine("");
            Console.WriteLine("The total values of sales of motor cylces " + totalMotorCyclesSaleValue);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside the Vehicle showroom");
            Console.WriteLine("");
            List<Vehicle> vehicles = new List<Vehicle>();

            Car fiesta = new Car("FES-UIT8", "60m/h", 200000, false);
           
            vehicles.Add(fiesta);

            Car ferrari = new Car("FER-IU8", "80m/h", 500000, false);
            vehicles.Add(ferrari);

            Console.WriteLine("");
            Console.WriteLine("********Cars info before sell***********");
            Car.DisplayListOfCars(vehicles);
            Console.WriteLine("***************************************");

            fiesta.sellCar(120000);

            Console.WriteLine("");
            Console.WriteLine("********Cars info after selling***********");
            Car.DisplayListOfCars(vehicles);
            Console.WriteLine("*****************************************");

            MotorCycle rxSporty = new MotorCycle("MRX-98HJ", "45m/h", 100000, false, 0);
            vehicles.Add(rxSporty);

            MotorCycle bullet = new MotorCycle("MBT-897HJ", "40m/h", 120000, false, 0);
            vehicles.Add(bullet);

            Console.WriteLine("**********MotoryCycles info before sell");
            MotorCycle.DisplayListOfMotors(vehicles);
            Console.WriteLine("***************************************");

            rxSporty.sellMotorCycle(55000);

            Console.WriteLine("*********MotorCycles info after sell");
            MotorCycle.DisplayListOfMotors(vehicles);
            Console.WriteLine("***************************************");

            Console.WriteLine("");
            Car.CalculateValueOfStock(vehicles);
            MotorCycle.CalculateValueOfStock(vehicles);

            MotorCycle.TotalValueOfSalesMotorCylce();
            Car.TotalValueOfSalesCars();

            Console.WriteLine("");
            fiesta.DisplayVehicleInfo();

            vehicles.Clear();
             Vehicle vehicle1 = new Car();
            Car car1 = new Car();
            Vehicle vehicle2 = new MotorCycle();
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            vehicles.Add(car1);
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine("Type : " + vehicle.GetType());
                vehicle.NumberOfWheels();
            }

        }
    }
}
