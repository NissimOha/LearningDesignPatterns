using System;
using System.Collections.Generic;

namespace Nissim.On.Factory
{
    class Program
    {
        public static void Main(string[] args)
        {
            CarFactory randomCar = new RandomCarFactory();
            List<Car> cars = new List<Car>()
            {
                randomCar.GenerateRandomCar(),
                randomCar.GenerateRandomCar(),
                randomCar.GenerateRandomCar(),
                randomCar.GenerateRandomCar(),
                randomCar.GenerateRandomCar()
            };
            
            foreach(var car in cars)
            {
                Console.WriteLine("Car: {0}\tColor {1}\tPrice: {2}", car.CarType, car.Color ,car.price());
            }
        }
    }
}
