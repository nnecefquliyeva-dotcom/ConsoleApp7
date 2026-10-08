using System;
using System.Collections.Generic;
namespace ConsoleApp7
{
    class Vehicle
    {
        public string Brand = "";
        public int Speed;
        public virtual void MakeSound()
        {
            Console.WriteLine("Nəqliyyat vasitəsi səs çıxarır.");
        }
    }
    class Car : Vehicle
    {
        public override void MakeSound()
        {
            Console.WriteLine(Brand + ": Maşın siqnal verir");
        }
    }
    class Motorcycle : Vehicle
    {
        public override void MakeSound()
        {
            Console.WriteLine(Brand + ": Motosiklet sesi");
        }
    }
    class Bicycle : Vehicle
    {
        public override void MakeSound()
        {
            Console.WriteLine(Brand + ": Velosiped zengi");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Car
            {
                Brand = "Mercedes",
                Speed = 180
            });

            vehicles.Add(new Motorcycle
            {
                Brand = "Honda",
                Speed = 150
            });

            vehicles.Add(new Bicycle
            {
                Brand = "Giant",
                Speed = 25
            });

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.MakeSound();
            }
        }
    }
}