using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch;
using AutoMapper;


namespace DynamicsGPJDFAPI.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/jdf")]
    [Produces("application/json")]
    public class CustomersController : Controller
    {
        Services.IGenericEFFactory _rep;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rep"></param>
        public CustomersController(Services.IGenericEFFactory rep) { _rep = rep; }
        /// <summary>
        /// Get all of the customers 
        /// </summary>
        /// <returns>Json object of customers</returns>
        [HttpGet("customers")]
        public IActionResult Get()
        {
            var items = _rep.Get<Entities.Rm00101>();
            var DTOs = Mapper.Map<IEnumerable<Models.Rm00101DTO>>(items);
            return Ok(DTOs);
        }
        /// <summary>
        /// Get an individual customer 
        /// </summary>
        /// <param name="customer">Valid customer number</param>
        /// <returns>Json object containing the customer</returns>
        [HttpGet("customers/{customer}")]
        public IActionResult Get(string customer)
        {
            if (customer == null) return BadRequest();
            try
            {
                var items = _rep.Get<Entities.Rm00101>(customer);
                var DTO = Mapper.Map<Models.Rm00101DTO>(items);

                return Ok(DTO);
            }
            catch (Exception)
            {
                return BadRequest();
            }


        }
    }
}
