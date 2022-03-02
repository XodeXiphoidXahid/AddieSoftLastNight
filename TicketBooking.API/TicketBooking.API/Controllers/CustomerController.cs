using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketBooking.Book.BusinessObjects;
using TicketBooking.Book.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TicketBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = _customerService.GetAllCustomer();
            return Ok(result);
        }

        // GET api/<ValuesController>/5
        //[HttpGet("get-customer/{id}")]
        //public string GetCustomerById(Guid id)
        //{
        //    return "value";
        //}

        [HttpGet("get-customer/{id}")]
        public IActionResult GetCustomerById(Guid id)
        {
            return Accepted("https://www.w3schools.com/sql/sql_drop_table.asp");
        }

        [HttpGet("get-single-customer/{id}")]
        public IActionResult GetSingleCustomerById([FromRoute] Guid id)
        {
            var result = _customerService.GetSingleCustomer(id);
            return Ok(result);
        }


        [HttpGet("search")]
        public string SearchCustomer(int id, int age, string name)
        {
            return "Done";
        }


        // POST api/<ValuesController>
        [HttpPost("add-customer")]
        public ActionResult AddCustomer([FromBody]Customer customer)
        {
            var id = _customerService.CreateCustomer(customer);

            return CreatedAtAction(nameof(GetCustomerById), new { id = id, controller = "Customer" }, id);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("update-book-{id}")]
        public ActionResult Put(Guid id, [FromBody] Customer customer)
        {
            _customerService.UpdateCustomer(id, customer);
            return Ok();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


       
    }
}
