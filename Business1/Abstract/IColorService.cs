using Core.Utilities.Results.Abstact;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetAllById(int colorId);
        IDataResult<List<Color>> GetAllByColorName(string colorName);
        IResult Add(Color color);
        IDataResult<Color> GetById(int colorId);
        IResult Delete(Color color);
        IResult Update(Color color);
    }
}
