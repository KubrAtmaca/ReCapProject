using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstact;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _ıbrandDal;

        public BrandManager(IBrandDal ıbrandDal)
        {
            _ıbrandDal = ıbrandDal;
        }
        public BrandManager()
        {

        }

        public IResult Add(Brand car)
        {
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Brand brand)
        {
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_ıbrandDal.GetAll());
        }

        public IDataResult<List<Brand>> GetAllByBrandName(string brandName)
        {
            return new SuccessDataResult<List<Brand>>(_ıbrandDal.GetAll(b => b.BrandName == brandName));
        }

        public IDataResult<List<Brand>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Brand>>(_ıbrandDal.GetAll(b => b.BrandId == id));
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_ıbrandDal.Get(b => b.BrandId == brandId));
        }

        public IResult Update(Brand brand)
        {
            return new SuccessResult(Messages.Updated);
        }
    }
}
