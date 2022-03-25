using DiscountApp.Api.Models;
using System;
using System.Collections.Generic;

namespace DiscountApp.Api.Data
{
    public class MockDatas
    {
        public List<CustomerType> customerTypes()
        {
            var customerTypes = new List<CustomerType>()
            {
                 new CustomerType
                  {
                      Id = 1,
                      Type = "Employee",
                      DiscountRatio = 30
                  },
                  new CustomerType
                  {
                      Id = 2,
                      Type = "Long Term Customer",
                      DiscountRatio = 10
                  },
                  new CustomerType
                  {
                      Id = 3,
                      Type = "Member",
                      DiscountRatio = 5
                  }
            };
            return customerTypes;
        }
    }
}
