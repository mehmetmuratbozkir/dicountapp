using DiscountApp.Api.Helpers.Results.Abstract;
using DiscountApp.Api.Model;
using DiscountApp.Api.Models;

namespace DiscountApp.Api.Business.Abstract
{
    public interface IDiscountCalculater
    {
        IDataResult<DiscountDetail> Calculate(CalculateInputParameters param, CustomerType customerType);
    }
}
