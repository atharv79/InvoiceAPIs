using System;
using System.Linq;

namespace InvoiceAPI.Models
{
    public class Invoice
	{
		public int Id { get; set; }
		public string InvoiceNumber { get; set; } = string.Empty;
		public string InvoiceDate { get; set; }

		public string CustName { get; set; } = string.Empty;
		public string CustEmail { get; set; } = string.Empty;

		public List<InvoiceItems> Items { get; set; } = new();

		public decimal Total => Items.Sum(i => i.ItemTotal);
		public decimal Tax => Total * 0.18m;
		public decimal FinalTotal => Total + Tax;	
	}

	public class InvoiceItems
	{
		public string Desc { get; set; } = string.Empty;
		public int Quantity { get; set; }
		public decimal Price { get; set; }

		public decimal ItemTotal => Quantity * Price;
	}
}
