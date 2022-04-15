using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Apartment.App.Web.Models.InvoiceTypeModels
{
    public class InvoiceTypeViewModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
       
        public string TypeUnit { get; set; }
    }
}
