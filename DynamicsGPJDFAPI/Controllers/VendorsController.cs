using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch;
using AutoMapper;

namespace DynamicsGPJDFAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/jdf")]
    public class VendorsController : Controller
    {
        Services.IGenericEFFactory _rep;
        /// <summary>
        /// Vendors Control constructor
        /// </summary>
        /// <param name="rep">Injecting IGenericFactory interface</param>
        public VendorsController(Services.IGenericEFFactory rep)
        {
            _rep = rep;
        }
        /// <summary>
        /// Get all vendors
        /// </summary>
        /// <returns>Json object listing all of the vendors</returns>
        [HttpGet("vendors")]
        public IActionResult Get()
        {
            var items = _rep.Get<Entities.Pm00300>();
            var DTOs = Mapper.Map<IEnumerable<Models.Pm00300DTO>>(items);
            return Ok(DTOs);
        }
        /// <summary>
        /// Get a specificic vendor based on the Vendor ID
        /// </summary>
        /// <param name="vendor">The vendor that we are looking for</param>
        /// <returns>Json object representing the retrieved vendor</returns>
        // GET api/values/5
        [HttpGet("vendors/{vendor}")]
        public IActionResult Get(string vendor)
        {
            
            if (vendor == null) return BadRequest();
                
                try
                {
                    var item = _rep.Get<Entities.Pm00300>(vendor, "PRIMARY");
                    if (item == null) return NotFound();

                    var DTO = Mapper.Map<Models.Pm00300DTO>(item);

                    return Ok(DTO);
                }
                catch (Exception)
                {
                    return BadRequest();
                }

               
            
           
           
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
