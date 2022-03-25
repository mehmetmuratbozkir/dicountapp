using DiscountApp.Api.Helpers.Results.Abstract;
using DiscountApp.Api.Helpers.Results.Concrete;
using DiscountApp.Api.Models;
using DiscountApp.Api.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DiscountApp.Test.Controllers
{
    public class CutomersTypesController
    {
        private readonly Mock<ICustomerTypeRepostory> _mockRepo;
        private readonly Api.Controllers.CutomerTypesController _controller;

        private List<CustomerType> customerTypes;
        private SuccessDataResult<List<CustomerType>> _successDataResult;
        public CutomersTypesController()
        {
            _mockRepo = new Mock<ICustomerTypeRepostory>();
            _controller = new Api.Controllers.CutomerTypesController(_mockRepo.Object);

            customerTypes = new List<CustomerType>()
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
            _successDataResult = new SuccessDataResult<List<CustomerType>>(customerTypes, "");
        }
        [Fact]
        public void GetAll_AcitionExecute_Return_Ok_Result_With_Dataset()
        {
            _mockRepo.Setup(x => x.Get()).Returns(_successDataResult);
            var result = _controller.GetAll();
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnDataset = Assert.IsAssignableFrom<dynamic>(okResult.Value);
            var daynamicResult = new SuccessDataResult<List<CustomerType>>(returnDataset.Data, "");
            Assert.True(returnDataset.Success);
            Assert.Equal<int>(3, daynamicResult.Data.Count);
            Assert.Equal<int>(1, daynamicResult.Data[0].Id);
            Assert.Equal<decimal>(30, daynamicResult.Data[0].DiscountRatio);
        }
    }
}
