using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Apartment.App.Domain.Entities.IdentityEntities;
using Apartment.App.Domain.NewFolder;

namespace Apartment.App.Domain.Entities
{
    public class Housing:BaseEntity
    {
        public User user { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsHomeowner { get; set; }
        public int BlokNumber { get; set; }
        public int FloorNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public string ApartmentSizeInfo { get; set; }
         
    }
}
