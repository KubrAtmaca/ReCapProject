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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContex>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDtos()
        {
            using (ReCapProjectContex contex=new ReCapProjectContex())
            {
                var result = from r in contex.Rentals
                             join ca in contex.Cars
                             on r.CarId equals ca.CarId
                             join cu in contex.Customers
                             on r.CustomerId equals cu.CustomerId
                             join u in contex.Users
                             on cu.CustomerId equals u.UserId
                             select new RentalDetailDto
                             {
                                 RentalId=r.Id,
                                 CarName=ca.CarName,
                                 FirstName=u.FirstName,
                                 LastName=u.LastName,
                                 CompanyName=cu.CompanyName,
                                 Description=ca.Description,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
