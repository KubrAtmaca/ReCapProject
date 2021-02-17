using Core.Utilities.Results.Abstact;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByBrandId(int id);
        IDataResult<List<Car>> GetAllById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailDtos();
        
    }
}
