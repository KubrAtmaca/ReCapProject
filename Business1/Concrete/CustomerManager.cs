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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _ıcustomerDal;

        public CustomerManager(ICustomerDal ıcustomerDal)
        {
            _ıcustomerDal = ıcustomerDal;
        }
        public CustomerManager()
        {

        }

        public IResult Add(Customer customer)
        {
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Customer customer)
        {
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_ıcustomerDal.GetAll());
        }

        public IDataResult<List<Customer>> GetAllByCompanyName(string companyName)
        {
            return new SuccessDataResult<List<Customer>>(_ıcustomerDal.GetAll(c=>c.CompanyName==companyName)); ;
        }

        public IDataResult<List<Customer>> GetAllById(int customerId)
        {
            return new SuccessDataResult<List<Customer>>(_ıcustomerDal.GetAll(c=>c.CustomerId==customerId));
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer>(_ıcustomerDal.Get(c=>c.CustomerId==customerId));
        }

        public IResult Update(Customer customer)
        {
            return new SuccessResult(Messages.Updated);
        }
    }
}
