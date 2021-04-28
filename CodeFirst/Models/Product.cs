using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
    }
    public class ProductContext : DbContext
    {
        public ProductContext() : base("Data Source=PCIN490774;Initial Catalog=test;Integrated Security=True")
        {

        }
        public virtual DbSet<Product> Products { get; set; }
        public static void Main(string[] args)
        {
            using (ProductContext p = new ProductContext())
            {
                Product product = new Product()
                {
                    Name = "Samsung",
                    Price = 17000,
                    Rating = 3
                };
                p.Products.Add(product);
                p.SaveChanges();
            }
        }
    }
}