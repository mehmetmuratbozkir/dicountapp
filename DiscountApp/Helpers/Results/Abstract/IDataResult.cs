using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountApp.Api.Helpers.Results.Abstract
{
    public interface IDataResult<out T>:IResult
    {
        T Data { get; }
    }
}
