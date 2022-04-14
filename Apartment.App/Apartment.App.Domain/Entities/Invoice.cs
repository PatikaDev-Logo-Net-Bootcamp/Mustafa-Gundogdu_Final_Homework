using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Apartment.App.Domain.Entities.IdentityEntities;
using Apartment.App.Domain.NewFolder;

namespace Apartment.App.Domain.Entities
{
    public class Invoice:BaseEntity
    {

        public User user { get; set; }
        public Housing housing { get; set; }
        public InvoiceType InvoiceType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastSpendDate { get; set; }
        public bool IsSpended { get; set; }
        public int TotalDay { get; set; }
        public int InvoiceAmountOfUse { get; set; }
        public int InvoicePrice { get; set; }

    }
}
