using Business.Concrete;
using DataAccess.Concrete.InMemory;
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

            foreach (var car in carManager.GetAllByBrand(2))
            {
                Console.WriteLine(car.Id + " " + car.Description); 
            }
        }
    }
}
