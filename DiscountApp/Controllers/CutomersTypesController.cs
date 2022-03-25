using DiscountApp.Api.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiscountApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CutomerTypesController : ControllerBase
    {
        private ICustomerTypeRepostory _repostory;
        public CutomerTypesController(ICustomerTypeRepostory repostory)
        {
            _repostory = repostory;
        }
        
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_repostory.Get());
        }
    }
}
