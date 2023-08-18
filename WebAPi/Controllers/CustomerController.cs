using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPi.Service;

namespace WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService service;
        public CustomerController(ICustomerService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {

            var data = this.service.GetAll();
            if (data == null)
            {

                return NotFound();

            }
            return Ok(data);
        }
    }
}
