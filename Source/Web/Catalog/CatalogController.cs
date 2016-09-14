using System.Collections.Generic;
using System.Threading;
using Microsoft.AspNetCore.Mvc;

namespace Web.Catalog
{
    [Route("api/[controller]")]
    public class CatalogController : Controller
    {
        [HttpGet("{category}")]
        public IEnumerable<Product> Get(string category)
        {
            if( category == "slow" ) {
                Thread.Sleep(1000);
            }

            if( category == "superslow" ) {
                Thread.Sleep(10000);
            }

            return new Product[] {
                new Product { Sku = "123456", Title = "Something cool", Price = 100 }
            };
        }
    }
}
