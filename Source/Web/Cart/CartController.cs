using System.Threading;
using Microsoft.AspNetCore.Mvc;

namespace Web.Cart
{
    [Route("api/[controller]")]
    public class CartController : Controller
    {
        [HttpPost]
        public void Post([FromBody] string sku, [FromBody] int quantity)
        {
            if( sku == "slow") Thread.Sleep(1000);
            if( sku == "superslow") Thread.Sleep(10000);
        }
    }
}