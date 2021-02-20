using Core.Utilities.Results.Abstact;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetAllById(int rentalId);
        IDataResult<List<Rental>> GetAllByCarId(int carId);
        IDataResult<List<Rental>> GetAllByCustomerId(int customerId);
        IDataResult<List<Rental>> GetAllByRentDate(DateTime rentDate);
        IDataResult<List<Rental>> GetAllByReturnDate(DateTime returnDate);
        IDataResult<Rental> GetByReturnDateNull(int carId);
        IDataResult<Rental> GetByCarId(int carId);
        IDataResult<Rental> GetByCustomerId(int customerId);
        IResult Add(Rental rental);
        IDataResult<Rental> GetById(int rentalId);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IDataResult<List<RentalDetailDto>> GetRentalDetailDtos();
    }
}
