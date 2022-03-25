using DiscountApp.Api.Business.Abstract;
using DiscountApp.Api.Business.Concrete;
using DiscountApp.Api.Helpers.Results.Concrete;
using DiscountApp.Api.Model;
using DiscountApp.Api.Models;
using DiscountApp.Api.Services.Abstract;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DiscountApp.Test.Business
{
    public class DiscountCalculaterTest
    {
        [Fact]
        public void Calculate_SimpleValue_Expected()
        {
            var customerType = new CustomerType
            {
                Id = 1,
                Type = "Employee",
                DiscountRatio = 30
            };

            var inputParam = new CalculateInputParameters
            {
                Price = 999,
                CustomerTypeId = 1
            };

            var discountCalculater = new DiscountCalculater();
            var calculate = discountCalculater.Calculate(inputParam, customerType);

            Assert.True(calculate.Success);
            Assert.Equal(30, calculate.Data.DiscountRatio);
            Assert.Equal(299.7, Convert.ToDouble(calculate.Data.Discount));
            Assert.Equal(45, calculate.Data.TotalPriceDiscount);
            Assert.Equal(999, calculate.Data.TotalPrice);
            Assert.Equal(654.3, Convert.ToDouble(calculate.Data.PayableTotalPrice));
        }

    }
}
