using DiscountApp.Api.Business.Abstract;
using DiscountApp.Api.Helpers.Results.Abstract;
using DiscountApp.Api.Helpers.Results.Concrete;
using DiscountApp.Api.Model;
using DiscountApp.Api.Models;
using DiscountApp.Api.Services.Abstract;
using FiftyVisitor.Api.Utilities.Constants;
using System;
using System.Linq;

namespace DiscountApp.Api.Business.Concrete
{
    public class DiscountCalculater : IDiscountCalculater
    {
        public IDataResult<DiscountDetail> Calculate(CalculateInputParameters param, CustomerType customerType)
        {
            var details = new DiscountDetail();
            try
            {
                details.DiscountRatio = customerType.DiscountRatio;
                details.TotalPrice = param.Price;
                details.Discount = (param.Price * customerType.DiscountRatio) / 100;
                details.TotalPriceDiscount = (Math.Floor(param.Price / 100)) * 5;
                details.PayableTotalPrice = param.Price > 0 ? (param.Price - details.Discount) - details.TotalPriceDiscount : 0;
                return new SuccessDataResult<DiscountDetail>(details, "");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<DiscountDetail>(details, Messages.sorryAnErrorOccurred);
            }

        }
    }
}
