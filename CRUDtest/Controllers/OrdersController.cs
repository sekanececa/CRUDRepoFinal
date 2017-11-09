using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUDtest.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Order.CreateOrder());
        }

        public class Order
        {
            public int OrderId { get; set; }
            public string CustomerName { get; set; }
            public string ShipperCity { get; set; }
            public Boolean IsShipped { get; set; }

            public static List<Order> CreateOrder()
            {
                List<Order> OrderList = new List<Order>()
                {
                    new Order { OrderId=1111,CustomerName="Ivan Marjanovic",ShipperCity="BG", IsShipped=true},
                    new Order { OrderId=2222,CustomerName="Milica Markovic",ShipperCity="TW", IsShipped=false},
                    new Order { OrderId=3333,CustomerName="Milica Bogdanovic",ShipperCity="VF", IsShipped=false},
                    new Order { OrderId=4444,CustomerName="Miroslav Mrdakovic",ShipperCity="NS", IsShipped=true}
                };
                return OrderList;
            }

        }
    }
}
