using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;


namespace CRUDtest.Controllers
{
    //[IdentityBasicAuthentication]
    // [Authorize]
    //pokusaj authentication i authorization
    //https://docs.microsoft.com/en-us/aspnet/web-api/overview/security/authentication-filters

    //http://blog.iteedee.com/2014/03/asp-net-identity-2-0-cookie-token-authentication/
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        //public IHttpActionResult Get()
        //{


        //}

        //public IHttpActionResult Post()
        //{

        //}
       
    }
}
