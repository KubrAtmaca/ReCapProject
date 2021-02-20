using Core.Utilities.Results.Abstact;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetAllById(int id);
        IDataResult<List<Brand>> GetAllByBrandName(string brandName);
        IResult Add(Brand brand);
        IDataResult<Brand> GetById(int brandId);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);

    }
}
