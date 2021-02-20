using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using Entity.Concrete;
using Entity.DTOs;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
       
    }
}
