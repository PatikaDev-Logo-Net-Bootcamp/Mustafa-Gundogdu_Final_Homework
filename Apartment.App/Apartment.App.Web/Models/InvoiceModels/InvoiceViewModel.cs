using System.Collections.Generic;
using Apartment.App.Business.DTO;
using Apartment.App.Web.Models.InvoiceModels;

namespace Apartment.App.Web.Models.InvoiceModels
{
    public class InvoiceViewModel
    {
        public InvoiceViewModel()
        {
            Invoices = new List<InvoiceModel>();
        }
        public List<InvoiceModel> Invoices { get; set; }
        public bool isUserAdmin { get; set; }
    }
}
