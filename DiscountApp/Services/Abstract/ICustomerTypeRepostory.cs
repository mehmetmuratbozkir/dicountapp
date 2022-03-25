using DiscountApp.Api.Helpers.Results.Abstract;
using DiscountApp.Api.Models;
using System.Collections.Generic;

namespace DiscountApp.Api.Services.Abstract
{
    public interface ICustomerTypeRepostory
    {
        IDataResult<List<CustomerType>> Get();
        IDataResult<CustomerType> GetById(int id);
    }
}
