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
        public void Put([FromBody]AddItemsToCart command)
        {
            if( command.Sku == "slow") Thread.Sleep(1000);
            if( command.Sku == "superslow") Thread.Sleep(10000);

            Console.WriteLine($"Adding {command.Quantity} of {command.Sku}");

            _cartHub.Clients.All.itemAdded(new {sku = command.Sku, quantity = command.Quantity});
        }
    }
}