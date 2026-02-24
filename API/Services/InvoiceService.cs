using InvoiceAPI.Models;

namespace InvoiceAPI.Services
{
    public class InvoiceService
    {

        private readonly List<Invoice> _invoices;

        public InvoiceService()
        {
            _invoices = new List<Invoice>
            {
                new Invoice
                {
                    Id = 1,
                InvoiceNumber = "INV - 0001",
                InvoiceDate = DateTime.UtcNow.ToShortDateString(),

                CustName = "Maverick",
                CustEmail = "maverick@yopmail.com",

                    Items = new List<InvoiceItems>
                    {
                        new InvoiceItems
                        {
                            Desc = "Software Dev",
                            Quantity = 1,
                            Price = 5000
                        },

                        new InvoiceItems
                        {
                            Desc = "Cloud Dev",
                            Quantity= 1,
                            Price = 7000
                        }
                    }
                },

                new Invoice
                {
                    Id = 2,
                InvoiceNumber = "INV - 0002",
                InvoiceDate = DateTime.UtcNow.ToShortDateString(),

                CustName = "John Doe",
                CustEmail = "johnDoe@yopmail.com",

                    Items = new List<InvoiceItems>
                    {
                        new InvoiceItems
                        {
                            Desc = "Widget A",
                            Quantity = 1,
                            Price = 19
                        }
                    }
                }
            };
        }


        public Invoice GetInvoicebyID(int id)
        {
            return _invoices.FirstOrDefault( i => i.Id == id);

        }
    }
}
