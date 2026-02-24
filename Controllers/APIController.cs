
using Microsoft.AspNetCore.Mvc;
using InvoiceAPI.Models;
using InvoiceAPI.Services;
using System.Security.Cryptography.X509Certificates;

namespace InvoiceAPI.Controllers
{
    [ApiController]
    [Route("api/invoice")]
    public class InvoiceController : ControllerBase
    {
        private readonly InvoiceService _invoiceService;

        public InvoiceController (InvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpGet("{id}")]
        public IActionResult GetData(int id)
        {
            //string result = null;
            //if(result.Length > 0) // will throw NullReferenceException
            //{
            //    return Ok(new { message = "Data fetched" });
            //}
            
            var invoice = _invoiceService.GetInvoicebyID(id);

            if(invoice == null)
            {

                return BadRequest("No data");
                //return NotFound();
            }

            return Ok(invoice);
        }
    }
}
