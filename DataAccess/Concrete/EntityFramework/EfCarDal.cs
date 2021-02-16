using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContex>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using (ReCapProjectContex contex=new ReCapProjectContex())
            {
                var result = from ca in contex.Cars
                             join co in contex.Colors
                             on ca.ColorId equals co.ColorId
                             join b in contex.Brands
                             on ca.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId=ca.CarId,
                                 CarName=ca.CarName,
                                 BrandName=b.BrandName,
                                 ColorName=co.ColorName

                             };
                return result.ToList();
               
            }
        }
    }
}
