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
    public class ColorManager : IColorService
    {
        IColorDal _ıcolorDal;

        public ColorManager(IColorDal ıcolorDal)
        {
            _ıcolorDal = ıcolorDal;
        }
        public ColorManager()
        {

        }

        public IResult Add(Color color)
        {
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Color color)
        {
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_ıcolorDal.GetAll());
        }

        public IDataResult<List<Color>> GetAllByColorName(string colorName)
        {
            return new SuccessDataResult<List<Color>>(_ıcolorDal.GetAll(c => c.ColorName == colorName));
        }

        public IDataResult<List<Color>> GetAllById(int colorId)
        {
            return new SuccessDataResult<List<Color>>(_ıcolorDal.GetAll(c => c.ColorId == colorId));
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_ıcolorDal.Get(c => c.ColorId == colorId));
        }

        public IResult Update(Color color)
        {
            return new SuccessResult(Messages.Updated);
        }
    }
}
