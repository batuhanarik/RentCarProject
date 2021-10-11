using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CarManager carManager = new CarManager(new InMemoryCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id+" "+car.Description);
            //}

            //foreach (var car in carManager.GetCarsByBrandId(2))
            //{
            //    Console.WriteLine(car.CarId + " " + car.Description);
            //}

            //var car1 = new Car { CarId = 1, BrandId = 3, Description = "Honda Kiyaq", ColorId = 2, ModelYear = -2005, DailyPrice = 166 };
            //carManager.Add(car1);
        }
    }
}
