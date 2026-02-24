using InvoiceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceAPI.Controllers
{
    public class InvoiceViewController : Controller
    {
        private readonly InvoiceService _invoiceService;

        public InvoiceViewController(InvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        //URL: /invoice/view/1
        public IActionResult View( int id)
        {
            var invoice = _invoiceService.GetInvoicebyID(id);

            if(invoice == null)
            {
                return NotFound();
            }

            return View(invoice);
        }
    }
}
