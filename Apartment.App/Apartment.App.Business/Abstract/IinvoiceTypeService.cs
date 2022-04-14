using System;
using System.Collections.Generic;
using System.Text;
using Apartment.App.Domain.Entities;

namespace Apartment.App.Business.Abstract
{
    public interface IinvoiceTypeService
    {
        List<InvoiceType> getAllInvoiceTypes();
        InvoiceType GetInvoiceTypeById(int invoiceTypeId);
        string InvoiceTypeName(InvoiceType invoiceType);
        string InvoiceTypeUnit(InvoiceType invoiceType);
        void Add(InvoiceType invoiceType);
        void Update(InvoiceType invoiceType);
        void Delete(InvoiceType invoiceType);
    }
}
