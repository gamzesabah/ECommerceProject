using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ECommerceProject.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
        public string Link { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}