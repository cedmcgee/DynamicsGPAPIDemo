using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DynamicsGPAPI.Services;
using DynamicsGPAPI.Entities;
using DynamicsGPAPI.Models;
using AutoMapper;

namespace DynamicsGPAPI.Controllers
{
    [Route("api/vendors")]
    public class VendorsController : Controller
    {
        // private readonly DynamicsJDFDbContext _context;
        private readonly IGenericEFFactory _rep;
        public VendorsController(IGenericEFFactory rep)
        {
            // _context = context;
            _rep = rep;
        }
        /// <summary>
        /// Get list of Vendors
        /// </summary>
        /// <returns>Json collection of vendors</returns>
        [HttpGet]
        public IActionResult Get()
        {
            //var items = _rep.Get<Pm00300>();
            //var DTOs = Mapper.Map<IEnumerable<Pm00300DTO>>(items);

            return Ok();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
