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
    public class InvoicesController : Controller
    {
        private Services.IGenericEFFactory _rep;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rep"></param>
        public InvoicesController(Services.IGenericEFFactory rep)
        {
            _rep = rep;
        }
        /// <summary>
        /// Get all of the invoices in the system
        /// </summary>
        /// <returns>Json object of invoices</returns>
        [HttpGet("invoices")]
        public IActionResult Get()
        {
            var items = _rep.Get<Entities.Iv00101>();
            var DTOs = Mapper.Map<IEnumerable<Models.Iv00101DTO>>(items);
            return Ok(DTOs);
        }
        /// <summary>
        /// Get a specific invoice by invoice number
        /// </summary>
        /// <param name="invoice">Valid invoice number</param>
        /// <returns>Json object representing an invoice</returns>
        [HttpGet("invoices/{invoice}")]
        public IActionResult Get(string invoice)
        {
            if (invoice == null) return BadRequest();
            try
            {
                var items = _rep.Get<Entities.Iv00101>(invoice);
                var DTO = Mapper.Map<Models.Iv00101DTO>(items);

                return Ok(DTO);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
