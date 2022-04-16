using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Apartment.App.Business.DTO
{
    public class InvoiceDto
    {
        
        [Required]
        private InvoiceTypeDto invoiceTypr { get; set; }
    }
}
