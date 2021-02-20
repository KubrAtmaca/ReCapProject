using Core.Utilities.Results.Abstact;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetAllById(int customerId);
        IDataResult<List<Customer>> GetAllByCompanyName(string companyName);
        IResult Add(Customer customer);
        IDataResult<Customer> GetById(int customerId);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
    }
}
