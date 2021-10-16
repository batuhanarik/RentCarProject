using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //CarAddTest();
            //ColorAddTest();
            CarDetailsTest();

        }

        private static void CarDetailsTest()
        {
            var carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + car.BrandName + car.ColorName + car.DailyPrice);
            }
        }

        private static void ColorAddTest()
        {
            var colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { Name = "White" });
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            var car1 = new Car { CarId = 1, BrandId = 3, Description = "Honda Kiyaq", ColorId = 2, ModelYear = -2005, DailyPrice = 166 };
            carManager.Add(car1);
        }
    }
}
