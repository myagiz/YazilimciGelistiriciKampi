using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.Add(new Car
                { Id = 1, BrandId = 1, ColorId = 3, DailyPrice = 4000, ModelYear = 1995, Description = "Tofaş is very good !" }
            );
            Console.WriteLine("New car added !");
            foreach (var listOfCar in carManager.GetAll())
            {
                Console.WriteLine(listOfCar.Description);
            }
        }
    }
}
