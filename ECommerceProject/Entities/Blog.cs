using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ECommerceProject.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}