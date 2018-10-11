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
    /// Payments controller for payment interaction
    /// </summary>
    [Route("api/jdf")]
    [Produces("application/json")]
    public class PaymentsController : Controller
    {
        private Services.IGenericEFFactory _rep;
        /// <summary>
        /// Payment controller constructor injected with Entity framework interface
        /// </summary>
        /// <param name="rep">IGenericEFFactory</param>
        public PaymentsController(Services.IGenericEFFactory rep)
        {
            _rep = rep;
        }
        /// <summary>
        /// List of payments in the system
        /// </summary>
        /// <returns>Json object with payments in the system</returns>
        [HttpGet("payments")]
        public IActionResult Get()
        {
            var items = _rep.Get<Entities.Rm10201>();
            var DTOs = Mapper.Map<IEnumerable<Models.Rm10201DTO>>(items);
            return Ok(DTOs);
        }
        /// <summary>
        /// Get a particular payment by payment Id
        /// </summary>
        /// <param name="payment">Payment Id</param>
        /// <param name="code"></param>
        /// <returns>Json object with the payment information</returns>
        [HttpGet("payments/{payment}")]
        public IActionResult Get(string payment, short code )
        {
            if (payment == null) return BadRequest();
            try
            {
                var items = _rep.Get<Entities.Rm10201>(payment,code);
                var DTO = Mapper.Map<Models.Rm10201DTO>(items);

                return Ok(DTO);
            }
            catch (Exception e)
            {
                return StatusCode(500, "A problem occured while attempting to fulfill your request.");
            }
        }

    }
}
