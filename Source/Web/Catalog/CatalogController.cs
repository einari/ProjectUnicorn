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
            if( category == "slow") Thread.Sleep(1000);
            if( category == "superslow") Thread.Sleep(10000);

            return new Product[] {
                new Product { Sku = "35906", Title = "Venstre bak", Description = "For bilder med bremseskiver som er 278 mm i diameter. For biler med 12mm tykke bremseskiver", Price = 2709 },
                new Product { Sku = "35907", Title = "Høyre bak", Description = "For bilder med bremseskiver som er 278 mm i diameter. For biler med 12mm tykke bremseskiver", Price = 2709 },
                new Product { Sku = "72507", Title = "Venstre bak", Description = "Uten glider", Price = 1898 },
                new Product { Sku = "72508", Title = "Høyre bak", Description = "Uten glider", Price = 2709 },
                new Product { Sku = "27163", Title = "Xtreme", Description = "Xtreme-emblem. Dobbelsidig tape på baksiden. 115x40mm", Price = 59 },
                new Product { Sku = "27159", Title = "V6", Description = "V6-emblem. Dobbelsidig tape på baksiden. 70x35", Price = 39 },
                new Product { Sku = "27418", Title = "Tuing", Description = "Tunign-emblem. Dobbelsidig tape på baksiden. 105x23mm", Price = 39 }
            };
        }
    }
}
