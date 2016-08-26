using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_AP_01.Models;

namespace Web_AP_01.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product() {ID =1, Name ="computer", Category = "Internet",Price = 1 },
            new Product() { ID = 2, Name ="Lap top", Category = "Pc", Price = 2},
            new Product() { ID = 3, Name ="Fen", Category = "Electronic", Price = 3}
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.ID == id);
            if (product == null)
                return NotFound();
            else
                return Ok(product);
        }
    }
}
