using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class CarDTO
    {
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public string TechnicalPassport { get; set; }
        public float LoadCapacity { get; set; }
        public float Volume { get; set; }
        public string Color { get; set; }
        public string Vin { get; set; } // check variable naming
        public string Category { get; set; }
        public int? UserId { get; set; }
    }
}
