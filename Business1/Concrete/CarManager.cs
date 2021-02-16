using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _ıcarDal;

        public CarManager(ICarDal carDal)
        {
            _ıcarDal = carDal;
        }
        public CarManager()
        {

        }
        public List<Car> GetAll()
        {
            return _ıcarDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _ıcarDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetAllById(int id)
        {
            return _ıcarDal.GetAll(c => c.CarId == id);
        }
        public void Add(Car car)
        {
            if (car.Description.Length>=2 && car.DailyPrice>0)
            {
                _ıcarDal.Add(car);
            }
            else
            {
                Console.WriteLine("Hata!! Description 2 karakterden fazla olmalı ve fiyat 0 dan büyük olmalı!");
            }
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            return _ıcarDal.GetCarDetailDtos();
        }
    }
}
