//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using CRUDtest.Models;


////pokusaj za pravljenje user accaunta
////pokusaj realizacije tutorijla za login
////https://www.youtube.com/watch?v=Uq0y8oxnx-8
//namespace CRUDtest.Controllers
//{
//    public class AccauntController : Controller
//    {
//        // GET: Accaunt
//        public ActionResult Index()
//        {
//            using (UserDbContext db= new UserDbContext())
//            {
//                return View(db.userAccaunt.ToList());
//            }
//        }
//        public ActionResult Register()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Register(User account)
//        {
//            if (ModelState.IsValid)
//            {

//                using (UserDbContext db=new UserDbContext())
//                {
//                    db.userAccaunt.Add(account);
//                    db.SaveChanges();
//                }
//                ModelState.Clear();
//                ViewBag.Message = account.FirstName + " " + account.LastName + " succesfully registered.";
//            }
//            return View();
//        }
//        //login
//        public ActionResult Login()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Login(User user)
//        {
//            using (UserDbContext db=new UserDbContext())
//            {
//                var usr = db.userAccaunt.Single(u=>u.UserName==user.UserName && u.Password==user.Password);
//                if (usr!=null)
//                {
//                    Session["User ID"] = usr.UserID.ToString();
//                    Session["User Name"] = usr.UserName.ToString();
//                    return RedirectToAction("LoggedIn.");
//                }
//                else
//                {
//                    ModelState.AddModelError("","Username od Password is wrong");
//                }
//            }
//            return View();
//        }

//        public ActionResult LoggedIn()
//        {
//            if (Session["UserID"]!=null)
//            {
//                return View();
//            }
//            else
//            {
//                return RedirectToAction("Login");
//            }
//        }
//    }
//}