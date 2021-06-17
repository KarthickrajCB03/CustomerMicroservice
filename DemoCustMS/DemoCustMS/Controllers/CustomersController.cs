using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Added..
using DemoCustMS.Services;
using DemoCustMS.Models;

namespace DemoCustMS.Controllers
{
    //[Route("api/[controller]")] - This was Removed and [Route("api")] added

    [Route("api")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>
        [HttpGet]
        [Route("Customers")]
        public IEnumerable<Customer> Get()
        {
            return CustomerService.GetAll();
        }

        // GET api/<CustomerController>/5
        [HttpGet]
        [Route("GetCustomerDetails/{id}")]
        public Customer GetCustomerDetails(int id)
        {
            return CustomerService.Get(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        [Route("CreateCustomer")]
        public CustomerCreationStatus CreateCustomer(Customer cust)
        {
            return CustomerService.Add(cust);
        }

    }
}
