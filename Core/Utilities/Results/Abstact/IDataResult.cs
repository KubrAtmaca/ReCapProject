using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstact
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
