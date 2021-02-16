using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;

namespace ConsoleUI1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(car.CarId+"   "+car.CarName+"   "+car.BrandName+"   "+ car.ColorName);
            }
        }

       
    }
}
