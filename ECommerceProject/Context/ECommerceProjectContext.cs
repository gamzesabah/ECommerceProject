using ECommerceProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace ECommerceProject.Context
{
	public class ECommerceProjectContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Banner> Banners { get; set; }
    }
}
