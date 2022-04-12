using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public float Rating { get; set; }
        public bool IsHasCar { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
