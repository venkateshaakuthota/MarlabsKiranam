using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIMS.Models;

namespace WebAPIMS.Controllers
{
    public class ProductController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{Id=1,Name="Tomato",Category="Grocesorries",Price=10},
            new Product{Id=2,Name="Egg",Category="Produce",Price=20.01M},
            new Product{Id=3,Name="Carrot",Category="Red",Price=15.30M}
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products.ToList();
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
