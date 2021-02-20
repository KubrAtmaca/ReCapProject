using Core.Utilities.Results.Abstact;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetAllById(int userId);
        IDataResult<List<User>> GetAllByUserFirstName(string firstName);
        IDataResult<List<User>> GetAllByUserLastName(string lastName);
        IDataResult<List<User>> GetAllByUserName(string firstName, string lastName);
        IResult Add(User user);
        IDataResult<User> GetById(int userId);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
