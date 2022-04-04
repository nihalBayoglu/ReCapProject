using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            CarManager carManagerEf = new CarManager(new EfCarDal());

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.BrandId);
            //    Console.WriteLine(item.Description);
            //}

            Car carTest = new Car() { BrandId=2,ColorId=2,DailyPrice=0,ModelYear="2022",Description="ikinci araba" };
            Car carTest1 = new Car() { BrandId = 2, ColorId = 2, DailyPrice = 110, ModelYear = "2022", Description = "ikinci araba" };

            carManagerEf.AddCar(carTest);
            carManagerEf.AddCar(carTest1);


            foreach (var item in carManagerEf.GetAll())
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.BrandId);
                Console.WriteLine(item.Description);
            }

            Console.ReadLine();
            //var carList = carManager.GetAll();
            //var aa = from p in carList
            //         where p.Id == 1
            //         select new aaa { tr="a"};



               
        }
    }

    class aaa
    {
        public string tr;

    }
}
