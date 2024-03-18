using System;

namespace Car
{
    struct Car
    {
        double fuelComsumption;
        double fuel;

        public Car(double f)
        {
            this.fuelComsumption = f;
            this.fuel = 0;

        }

        public double getGasoline() { return fuel; }
        public void addGasoline(double g) { this.fuel = this.fuel + g; }

        public void walk(double km)
        {
            double liters = km / this.fuelComsumption;
            this.fuel = this.fuel - liters;
        }

        public override string ToString()
        {
            return "Fuel Comsumption: " + this.fuelComsumption +" km/l\nFuel: " + Math.Round(this.fuel,2) + " liters";
        }
    }

        public class Program
        {
            static void Main(string[] args)
            {

                Car myBeetle = new Car(15);
                Console.WriteLine(myBeetle.getGasoline());
                myBeetle.addGasoline(20);
                myBeetle.walk(100);
                Console.WriteLine(myBeetle);

            }
        }
    
}