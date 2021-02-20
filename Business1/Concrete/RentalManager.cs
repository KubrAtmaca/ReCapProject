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
    public class RentalManager : IRentalService
    {
        IRentalDal _ırentalDal;

        public RentalManager(IRentalDal ırentalDal)
        {
            _ırentalDal = ırentalDal;
        }
        public RentalManager()
        {

        }

        public IResult Add(Rental rental)
        {
            if (_ırentalDal.Get(r => r.CarId == rental.CarId).ReturnDate == null)
            {
                _ırentalDal.Add(rental);
                return new SuccessResult(Messages.Added);
            }
            return new ErrorResult(Messages.CanNotRent);
        }
    

        public IResult Delete(Rental rental)
        {
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_ırentalDal.GetAll());
        }

        public IDataResult<List<Rental>> GetAllByCarId(int carId)
        {
            return new SuccessDataResult<List<Rental>>(_ırentalDal.GetAll(r=>r.CarId==carId));
        }

        public IDataResult<List<Rental>> GetAllByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Rental>>(_ırentalDal.GetAll(r => r.CustomerId == customerId));
        }

        

        public IDataResult<List<Rental>> GetAllById(int rentalId)
        {
            return new SuccessDataResult<List<Rental>>(_ırentalDal.GetAll(r => r.Id == rentalId));
        }

        public IDataResult<List<Rental>> GetAllByRentDate(DateTime rentDate)
        {
            return new SuccessDataResult<List<Rental>>(_ırentalDal.GetAll(r => r.RentDate == rentDate));
        }

        public IDataResult<List<Rental>> GetAllByReturnDate(DateTime returnDate)
        {
            return new SuccessDataResult<List<Rental>>(_ırentalDal.GetAll(r => r.ReturnDate == returnDate));
        }

        public IDataResult<Rental> GetByCarId(int carId)
        {
            return new SuccessDataResult<Rental>(_ırentalDal.Get(r => r.CarId == carId));
        }

        public IDataResult<Rental> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<Rental>(_ırentalDal.Get(r => r.CustomerId == customerId));
        }

       

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_ırentalDal.Get(r => r.Id == rentalId));
        }

        public IResult Update(Rental rental)
        {
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<Rental> GetByReturnDateNull(int carId)
        {
            return new SuccessDataResult<Rental>(_ırentalDal.Get(r=>r.CarId==carId && r.ReturnDate==null));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailDtos()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_ırentalDal.GetRentalDetailDtos());
        }
    }
}
