using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public float Rating { get; set; }
        public bool IsHasCar { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
