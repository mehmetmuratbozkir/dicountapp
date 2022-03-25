using DiscountApp.Api.Data;
using DiscountApp.Api.Helpers.Results.Abstract;
using DiscountApp.Api.Models;
using DiscountApp.Api.Services.Abstract;
using FiftyVisitor.Api.Utilities.Constants;
using System.Collections.Generic;
using DiscountApp.Api.Helpers.Results.Concrete;
using System.Linq;

namespace DiscountApp.Api.Services.Concrete
{
    public class CustomerTypeRepostory : ICustomerTypeRepostory
    {
        public IDataResult<List<CustomerType>> Get()
        {
            var data = new MockDatas();
            return new SuccessDataResult<List<CustomerType>>(data.customerTypes(), "");
        }

        public IDataResult<CustomerType> GetById(int id)
        {
            var data = new MockDatas();
            var customerType = data.customerTypes().Where(x => x.Id == id).FirstOrDefault();
            return new SuccessDataResult<CustomerType>(customerType, "");
        }
    }
}
