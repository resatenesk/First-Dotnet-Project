using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _IcustomerService;

        public CustomersController(ICustomerService ıcustomerService)
        {
            _IcustomerService = ıcustomerService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll() { 
            var result = _IcustomerService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
            
        
        }
        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            var result = _IcustomerService.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
