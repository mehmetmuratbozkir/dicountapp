using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountApp.Api.Helpers.Results.Abstract
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
