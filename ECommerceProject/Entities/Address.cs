using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ECommerceProject.Entities;

namespace ECommerceProject.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Call { get; set; }
    }
}