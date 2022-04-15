using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Apartment.App.Web.Models.InvoiceTypeModels
{
    public class InvoiceTypeViewModel
    {
        public InvoiceTypeModel addInvoiceType { get; set; }
        public List<InvoiceTypeModel> invoiceTypes { get; set; }
    }
}
