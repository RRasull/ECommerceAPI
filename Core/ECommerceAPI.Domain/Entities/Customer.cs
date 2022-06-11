using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Entities
{
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
