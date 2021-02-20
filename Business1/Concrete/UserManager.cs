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
    public class UserManager : IUserService
    {
        IUserDal _ıuserDal;

        public UserManager(IUserDal ıuserDal)
        {
            _ıuserDal = ıuserDal;
        }
        public UserManager()
        {

        }

        public IResult Add(User user)
        {
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(User user)
        {
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_ıuserDal.GetAll());
        }

        public IDataResult<List<User>> GetAllById(int userId)
        {
            return new SuccessDataResult<List<User>>(_ıuserDal.GetAll(u => u.UserId == userId));
        }

        public IDataResult<List<User>> GetAllByUserFirstName(string firstName)
        {
            return new SuccessDataResult<List<User>>(_ıuserDal.GetAll(u => u.FirstName == firstName));
        }

        public IDataResult<List<User>> GetAllByUserLastName(string lastName)
        {
            return new SuccessDataResult<List<User>>(_ıuserDal.GetAll(u => u.LastName == lastName));
        }

        public IDataResult<List<User>> GetAllByUserName(string firstName, string lastName)
        {
            return new SuccessDataResult<List<User>>(_ıuserDal.GetAll(u => u.FirstName == firstName && u.LastName == lastName));
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_ıuserDal.Get(u => u.UserId == userId));
        }

        public IResult Update(User user)
        {
            return new SuccessResult(Messages.Updated);
        }
    }
}
