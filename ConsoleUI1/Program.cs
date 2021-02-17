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
            var result = carManager.GetCarDetailDtos();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + "   " + car.CarName + "   " + car.BrandName + "   " + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

       
    }
}
