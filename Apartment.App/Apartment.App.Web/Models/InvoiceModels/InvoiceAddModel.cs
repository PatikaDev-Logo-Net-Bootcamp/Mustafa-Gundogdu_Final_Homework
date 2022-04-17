using System.Collections.Generic;
using Apartment.App.Business.DTO;

namespace Apartment.App.Web.Models.InvoiceModels
{
    public class InvoiceAddModel
    {
        public List<HousingDto> Housings { get; set; } 
        public List<InvoiceTypeDto> invocieTypes { get; set; }
        public int housingId { get; set; }
        public string InvoiceOwnerTrIdentity { get; set; } 
        public int InvoiceTypeId { get; set; }
        public int TotalDay { get; set; }
        public double InvoiceAmountOfUse { get; set; }
        public double InvoiceUnitPrice { get; set; }
        public double InvoicePrice { get; set; }
  
    }
}
