using BusinessLayer;
using FeatureLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Users() 
        {
            return View();
        }

        [HttpGet]
        public JsonResult UserList() 
        {
            List<User> oList = new List<User>();

            oList = new CN_Users().ToList();

            //return Json(new { elemento = oList, estado=true }, JsonRequestBehavior.AllowGet);
            return Json(new { data = oList }, JsonRequestBehavior.AllowGet);
        }
    }
}