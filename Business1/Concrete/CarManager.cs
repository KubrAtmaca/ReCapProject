using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstact;
using Core.Utilities.Results.Concrete;
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

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_ıcarDal.GetAll());
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_ıcarDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Car>>(_ıcarDal.GetAll(c => c.CarId == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_ıcarDal.GetCarDetailDtos());
        }

        public IResult Add(Car car)
        {
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_ıcarDal.Get(c => c.CarId == carId));
        }

        public IResult Delete(Car car)
        {
            return new SuccessResult(Messages.Deleted);
        }

        public IResult Update(Car car)
        {
            return new SuccessResult(Messages.Updated);
        }
    }
}
