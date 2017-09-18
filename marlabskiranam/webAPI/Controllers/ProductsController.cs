using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webAPI.Models;

namespace webAPI.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
   {
    new Product { ProductID = 1, ProductName = "Product 1", ProductCategory= "Category 1", Price = 120 },
    new Product { ProductID = 2, ProductName = "Product 2", ProductCategory= "Category 1", Price = 100 },
    new Product { ProductID = 3, ProductName = "Product 3", ProductCategory= "Category 2", Price = 150 },
    new Product { ProductID = 4, ProductName = "Product 4", ProductCategory= "Category 3", Price = 90 }
   };
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
