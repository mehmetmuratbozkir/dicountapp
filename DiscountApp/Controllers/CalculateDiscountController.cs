using DiscountApp.Api.Business.Abstract;
using DiscountApp.Api.Model;
using DiscountApp.Api.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiscountApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateDiscount : ControllerBase
    {
        private readonly IDiscountCalculater _calculater;
        private readonly ICustomerTypeRepostory _repostory;
        public CalculateDiscount(IDiscountCalculater calculater, ICustomerTypeRepostory repostory)
        {
            _calculater = calculater;
            _repostory = repostory;
        }
        
        [HttpPost("Calculate")]
        public IActionResult Calculate(CalculateInputParameters param)
        {
            var customerType = _repostory.GetById(param.CustomerTypeId).Data;
            return Ok(_calculater.Calculate(param, customerType));
        }

    }
}
