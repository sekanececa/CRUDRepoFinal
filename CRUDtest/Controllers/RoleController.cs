//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using System.Web.Mvc;

//namespace CRUDtest.Controllers
//{
//    public class RoleController : ApiController
//    {
//        public ActionResult Index()
//        {

//            if (User.Identity.IsAuthenticated)
//            {


//                if (!isAdminUser())
//                {
//                    return RedirectToAction("Index", "Home");
//                }
//            }
//            else
//            {
//                return RedirectToAction("Index", "Home");
//            }

//            var Roles = context.Roles.ToList();
//            return View(Roles);

//        }
//    }
//}
