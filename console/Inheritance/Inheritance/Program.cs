using System;
using System.Collections.Generic;

namespace Inheritance
{

    public class Vehicle
    {
        //non static fields
        int price;
        string model;
        string mileage;
        int numberOfDoors;
        public bool sold;

        public Vehicle()
        {
            
        }
        public Vehicle(string model,string mileage,int price,bool sold)
        {
            this.model = model;
            this.mileage = mileage;
            this.price = price;
            this.sold = sold;
            this.numberOfDoors = 4;
        }

        public Vehicle(string model,string mileage,int price,bool sold,int numberOfDoors)
        {
            this.model = model;
            this.mileage = mileage;
            this.price = price;
            this.sold = sold;
            this.numberOfDoors = numberOfDoors;
        }

        public void sell(int price)
        {
            this.price = price;
        }

        public void DisplayVehicleInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("Model:{0} \nPrice : £{1:N0} " +
                              "\nMileage:{2}", this.model, this.price
                              , this.mileage);
        }
    }

    public class Car: Vehicle
    {
        static int numberOfCars  =  0;

        public Car(string model,string mileage,int price,bool sold):base( model, mileage, price,sold)
        {
            numberOfCars++;
        }

        public Car(string model,string mileage, int price,bool sold,int numberOfDoors):
        base(model,mileage,price,sold,numberOfDoors)
        {
            numberOfCars++;
        }

        public void sell(int price)
        {
            base.sell(price);
            numberOfCars++;
        }


    }

    public class MotorCycle: Vehicle
    {
        static int numberOFMotorCycle = 0;
        public MotorCycle(string model, string mileage, int price,bool sold) : base(model, mileage, price,sold)
        {
            numberOFMotorCycle++;
        }

        public MotorCycle(string model, string mileage, int price,bool sold, int numberOfDoors) : 
            base(model, mileage, price,sold, numberOfDoors)
        {
            numberOFMotorCycle++;
        }

        public void sell(int price)
        {
            base.sell(price);
            numberOFMotorCycle++;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside the Vehicle showroom");
            Console.WriteLine("");
            List<Car> cars = new List<Car>();

            Car fiesta = new Car("FES-UIT8", "60m/h", 200000, false);
            cars.Add(fiesta);

            Car ferrari = new Car("FER-IU8","80m/h",500000,false);
            cars.Add(ferrari);

            Console.WriteLine("********Car info before sell***********");
            fiesta.DisplayVehicleInfo();
            Console.WriteLine("***************************************");
            fiesta.sell(120000);

            Console.WriteLine("********Car info after selling***********");
            fiesta.DisplayVehicleInfo();
            Console.WriteLine("*****************************************");

        }
    }
}
