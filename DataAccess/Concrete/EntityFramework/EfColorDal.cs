using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (ReCapProject1Contex contex=new ReCapProject1Contex())
            {
                var addedEntity = contex.Entry(entity);
                addedEntity.State = EntityState.Added;
                contex.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (ReCapProject1Contex contex=new ReCapProject1Contex())
            {
                var deletedEntity = contex.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                contex.SaveChanges();
            }
        }

        public Color Get(Expression<Func< Color, bool >> filter )
        {
            using (ReCapProject1Contex contex=new ReCapProject1Contex())
            {
                return contex.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func< Color, bool >> filter  = null)
        {
            using (ReCapProject1Contex contex=new ReCapProject1Contex())
            {
                return filter == null ? contex.Set<Color>().ToList() : contex.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
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
