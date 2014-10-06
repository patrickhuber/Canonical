using Canonical.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Canonical.DomainServices.Controllers
{
    public class CustomerController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            return Ok(new Customer[] { });
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            return Ok("value");
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Customer customer)
        {
            customer.Id = new Random().Next();
            return Created<Customer>(
                string.Format("{0}{1}", Request.RequestUri, customer.Id.ToString()), 
                customer);
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]string value)
        {
            return Ok();
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}