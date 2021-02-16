using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapProject1Contex contex=new ReCapProject1Contex())
            {
                var addedEntity = contex.Entry(entity);
                addedEntity.State = EntityState.Added;
                contex.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapProject1Contex contex=new ReCapProject1Contex())
            {
                var deletedEntity = contex.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                contex.SaveChanges();
            }
        }

        public Car Get(Expression<Func< Car, bool >> filter )
        {
            using (ReCapProject1Contex contex=new ReCapProject1Contex())
            {
                return contex.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func< Car, bool >> filter  = null)
        {
            using (ReCapProject1Contex contex=new ReCapProject1Contex())
            {
                return filter == null ? contex.Set<Car>().ToList() : contex.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (ReCapProject1Contex contex=new ReCapProject1Contex())
            {
                var updatedEntity = contex.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                contex.SaveChanges();
            }
        }
    }
}
