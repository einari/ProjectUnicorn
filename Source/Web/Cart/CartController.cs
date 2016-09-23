using System;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Web.Cart
{
    [Route("api/[controller]")]
    public class CartController : Controller
    {
        IHubContext<CartHub> _cartHub;
        public CartController(IHubContext<CartHub> cartHub)
        {
            _cartHub = cartHub;
        }


        [HttpPut]
        public void Put([FromBody] string sku, [FromBody] int quantity)
        {
            if( sku == "slow") Thread.Sleep(1000);
            if( sku == "superslow") Thread.Sleep(10000);

            _cartHub.Clients.All.itemAdded(new {sku = sku, quantity = quantity});
        }
    }
}