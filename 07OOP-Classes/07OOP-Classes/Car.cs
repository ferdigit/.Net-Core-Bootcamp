using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07OOP_Classes
{
    internal class Car
    {
        public string brand;
        public string model;
        public int modelYear;
        public double km;
        public string fuelType;
        public string gearType;
        public double purchaseprice;
        public double sellPrice;
        public double maxDiscount;
        public double price;


        public Car(string brand, string model, int modelYear, double km, string fuelType, string gearType, double purchaseprice, double sellPrice, double maxDiscount)
        {
            this.brand = brand;
            this.model = model;
            this.modelYear = modelYear;
            this.km = km;
            this.fuelType = fuelType;
            this.gearType = gearType;
            this.purchaseprice = purchaseprice;
            this.sellPrice = sellPrice;
            this.maxDiscount = maxDiscount;
        }


        public Car(string model)
        {
            this.model = model;
        }

        public Car(string brand, string model, int modelYear)
        {
            this.brand = brand;
            this.model = model;
            this.modelYear = modelYear;
        }

        public Car(string brand, string model, int modelYear, double km)
        {
            this.brand = brand;
            this.model = model;
            this.modelYear = modelYear;
            this.km = km;
        }

        private double SetPrice(double sellPrice, double maxDiscount, double price)
        {
            if (maxDiscount >= 3)
            {
                this.price = 0;
                return price;
            }
            else
            {
               return price = sellPrice - maxDiscount;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Car brand is: {this.brand}");
            Console.WriteLine($"Car model is: {this.model}");
            Console.WriteLine($"Car year is: {this.modelYear}");
            Console.WriteLine($"Car km is: {this.km}");
            Console.WriteLine($"Car Fuel Type is: {this.fuelType}");
            Console.WriteLine($"Car Gear Type is: {this.gearType}");

            double price2 = SetPrice(sellPrice, maxDiscount, price);
            if (price2 == 0)
            {
                Console.WriteLine("\nYour discount is too much! Please check (it must be under 3!)");
            }
            else
            {
                Console.WriteLine($"Car price is: {price2}");
            }

        }



    }
}
