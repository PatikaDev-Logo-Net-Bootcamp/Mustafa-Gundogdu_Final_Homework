using System;
using System.Collections.Generic;
using System.Text;
using Apartment.App.Domain.NewFolder;

namespace Apartment.App.Domain.Entities
{
    public class InvoiceType:BaseEntity
    {
        public string TypeName { get; set; }
        public string InvoiceTypeUnit { get; set; }

    }
}
