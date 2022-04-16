using System;
using System.Collections.Generic;
using System.Text;

namespace Apartment.App.Business.DTO
{
    public class HousingDto
    {
        public UserDto User { get; set; }
        public List<InvoiceDto> Invoices { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsHomeowner { get; set; }
        public int BlokNumber { get; set; }
        public int FloorNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public string ApartmentSizeInfo { get; set; }
    }
}
